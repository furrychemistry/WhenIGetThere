using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;

namespace WhenIGetThere
{
	public enum AlgorithmActivity : byte
	{
		Driving,
		Break,
		Sleeping,
		Arrived,
	}

	public readonly struct AlgorithmDataPoint
	{
		private static readonly ConcurrentStack<StringBuilder> m_BuilderPool = new();

		private const string Hour12Format = "ddd, MM/dd/yy hh:mm tt";
		private const string Hour24Format = "ddd, MM/dd/yy HH:mm";

		public bool Use24HourFormat { get; init; }
		public AlgorithmActivity Activity { get; init; }
		public DateTime StartTimeStamp { get; init; }
		public TimeSpan Duration { get; init; }
		public double Distance { get; init; }
		public double AccumulatedDistance { get; init; }
		public bool DidWeTravel => Distance != 0;

		public override string ToString()
		{
			StringBuilder s;

			if (!m_BuilderPool.TryPop(out s))
				s = new();

			s.AppendFormat(Use24HourFormat ? Hour24Format : Hour12Format, StartTimeStamp);
			s.Append(" => ");
			s.Append(Activity);

			if (DidWeTravel)
				s.AppendFormat(" distance of {0}, {1} total", Distance, AccumulatedDistance);

			string retval = s.ToString();

			s.Clear();
			m_BuilderPool.Push(s);

			return retval;
		}
	}

	public class Algorithm : DataTable
	{
		public bool Use24HourFormat { get; init; }
		public TimeSpan CurrentActivityTimeRemaining { get; set; }
		public DateTime CurrentTimeStamp { get; init; }
		public AlgorithmActivity CurrentActivity { get; set; }
		public TimeSpan DriveTime { get; set; }
		public TimeSpan BreakTime { get; set; }
		public TimeSpan SleepTime { get; set; }
		public double Distance { get; set; }
		public double SpeedPerHour { get; set; }
		public double AccumulatedDistance { get; private set; }
	}
}