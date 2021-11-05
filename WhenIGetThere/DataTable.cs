using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Threading;

public class DataTable
{
	private readonly RawData<DataRecord> m_RawData;

	public ReadOnlyDictionary<int, DataRecord>.KeyCollection IDs
		=> m_RawData.ByID.Keys;

	public ReadOnlyDictionary<int, DataRecord>.ValueCollection Data
		=> m_RawData.ByID.Values;

	public int Count
		=> m_RawData.Count;

	public DataTable()
	{
		m_RawData = new(this);
	}

	/// <summary>
	/// Returns true if data was added.
	/// </summary>
	public virtual bool Add(DataRecord data)
		=> m_RawData.Add(data);

	/// <summary>
	/// Returns true if data was removed.
	/// </summary>
	public virtual bool Remove(DataRecord data)
		=> m_RawData.Remove(data);

	private sealed class RawData<T> where T : DataRecord, IDataRecord
	{
		const string ERR_DataHasOwner = "Data has an owner.";
		const string ERR_WrongOwner = "Data has a different owner.";
		const string ERR_DataDeleted = "Data is deleting or deleted.";

		private const int MAX_ID = int.MaxValue;
		private const int NULL_ID = 0;

		private int m_Count;
		private volatile int m_LastID;
		private readonly ConcurrentDictionary<int, T> m_ByID = new();
		private readonly DataTable m_Owner;
		internal readonly ReadOnlyDictionary<int, T> ByID;

		internal int Count
			=> m_Count;

		/// <exception cref="ArgumentNullException"/>
		internal RawData(DataTable owner)
		{
			m_Owner = owner ?? throw new ArgumentNullException();
			ByID = new ReadOnlyDictionary<int, T>(m_ByID);
		}

		/// <summary>
		/// Returns true if add succeeded. If the data point
		/// belongs to another or deleting/deleted, throw <see cref="ArgumentException"/>.
		/// </summary>
		/// <exception cref="ArgumentException"/>
		internal bool Add(T data)
		{
			// Validate data's state
			{
				if (data is null)
					return false;

				// When data cannot be used, throw.
				if (data.Deleted || data.DeleteCalled)
					throw new ArgumentException(ERR_DataDeleted);

				// When owner has been set...
				if (data.Owner is not null)
				{
					// When owner is a different instance, throw.
					if (!ReferenceEquals(data.Owner, m_Owner))
						throw new ArgumentException(ERR_DataHasOwner);

					// Already added.
					return false;
				}
			}

			Monitor.Enter(data);

			// Re-validate data's state.
			{
				// When data cannot be used, throw.
				if (data.Deleted || data.DeleteCalled)
				{
					Monitor.Exit(data);
					throw new ArgumentException(ERR_DataDeleted);
				}

				// When owner has been set...
				if (data.Owner is not null)
				{
					Monitor.Exit(data);

					// When owner is a different instance, throw.
					if (!ReferenceEquals(data.Owner, m_Owner))
						throw new ArgumentException(ERR_DataHasOwner);

					// Already added.
					return false;
				}
			}

			// Perform add.
			{
				int id;
				while (!m_ByID.TryAdd(id = NewID(), data)) ;
				data.SetOwnerAndID(m_Owner, id);
				Interlocked.Increment(ref m_Count);
			}

			Monitor.Exit(data);

			return true;
		}

		private int NewID()
		{
			while (true)
			{
				int id = m_LastID;

				if (id == MAX_ID)
					m_LastID = NULL_ID;

				m_LastID++;

				if (!m_ByID.ContainsKey(id))
					return id;
			}
		}

		internal bool Remove(int id)
			=> (id > NULL_ID && m_ByID.TryGetValue(id, out T data)) && Remove(data);

		internal bool Remove(T data)
		{
			// Validate data's state.
			{
				// Null or no owner.
				if (data?.Owner is null)
					return false;

				// If wrong owner, throw.
				if (!ReferenceEquals(data.Owner, m_Owner))
					throw new ArgumentException(ERR_WrongOwner);
			}

			Monitor.Enter(data);

			// Validate data's state.
			if (!ReferenceEquals(data.Owner, m_Owner))
			{
				Monitor.Exit(data);

				if (data.Owner is not null)
					throw new ArgumentException(ERR_WrongOwner);

				// Owner was null.
				return false;
			}

			int id = data.ID;
			data.SetOwnerAndID(null, 0);

			// Do removal.
			if (!m_ByID.TryRemove(new(id, data)))
			{
				Monitor.Exit(data);
				throw new ApplicationException("We don't know what happened, but we failed to remove a data entry.");
			}
			Interlocked.Decrement(ref m_Count);

			Monitor.Exit(data);

			return true;
		}
	}

	private interface IDataRecord
	{
		bool DeleteCalled { get; }

		void SetOwnerAndID(DataTable algorithm, int id);
	}

	public class DataRecord : IDataRecord
	{
		public bool DeleteCalled { get; private set; }

		public int ID { get; private set; }

		public DataTable Owner { get; private set; }

		public bool Deleted { get; private set; }

		public virtual string Name { get; set; }

		void IDataRecord.SetOwnerAndID(DataTable owner, int id)
		{
			ID = id;
			Owner = owner;
		}

		public virtual void Delete()
		{
			if (DeleteCalled)
				return;

			bool doDelete = false;

			Monitor.Enter(this);

			if (!DeleteCalled)
				DeleteCalled = doDelete = true;

			Monitor.Exit(this);

			if (doDelete)
			{
				Owner.Remove(this);
				Deleted = true;

				if (Owner is not null)
				{
					Owner.m_RawData.Remove(this);
					throw new ApplicationException("Owner failed to remove deleted data! "
						+ "Although data removal has been forced (to allow continued operation), THIS IS A BUG!.");
				}
			}
		}
	}
}