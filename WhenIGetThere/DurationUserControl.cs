using System;
using System.Text;
using System.Windows.Forms;

namespace WhenIGetThere
{
	public partial class DurationUserControl : UserControl
	{
		public DurationUserControl()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			static void CreateHourContextItems(ContextMenuStrip ctx)
			{
				const string format = "00 - 00 am"; // max chars used.
				StringBuilder bldr = new StringBuilder(format.Length);

				for (int i = 0; i < 24; i++)
				{
					bldr.Clear();
					if (i < 10) bldr.Append(0);
					bldr.Append(i);
					bldr.Append(" - ");
					bldr.Append(i == 0 ? 12 : i);
					bldr.Append(' ');
					bldr.Append(i < 12 ? "am" : "pm");

					var item = ctx.Items.Add(bldr.ToString());
					item.Tag = i;
				}
			}

			static void CreateMinuteContextItems(ContextMenuStrip ctx)
			{
				for (int i = 0; i < 60; i += 5)
				{
					var item = ctx.Items.Add(i.ToString() + " minutes");
					item.Tag = i;
				}
			}

			base.OnLoad(e);

			CreateHourContextItems(ctxHour);
			CreateMinuteContextItems(ctxMinute);
		}

		public bool Use24HourFormat
		{
			get => m_Use24HourFormat;
			set
			{
				if (value ^ m_Use24HourFormat)
				{
					m_Use24HourFormat = value;
					SelectedTime = SelectedTime;
				}
			}
		}
		private bool m_Use24HourFormat;

		public int SelectedMinute
		{
			get => m_SelectedMinute;
			set => lblMinute.Text = (m_SelectedMinute = Math.Clamp(value, 0, 59)).ToString("00");
		}
		private int m_SelectedMinute;

		public int SelectedHour
		{
			get => m_SelectedHour;
			set
			{
				m_SelectedHour = value = Math.Clamp(value, 0, 23);
				string text;

				if (Use24HourFormat)
				{
					text = value.ToString("00");
				}
				else
				{
					int displayHour;

					if (value == 0) displayHour = 12;
					else if (value > 12) displayHour = value - 12;
					else displayHour = value;

					text = displayHour.ToString() + (value < 12 ? " AM" : " PM");
				}

				lblHour.Text = text;
			}
		}
		private int m_SelectedHour;

		public TimeSpan SelectedTime
		{
			get => new TimeSpan(SelectedHour, SelectedMinute, 0);
			set
			{
				SelectedHour = value.Hours;
				SelectedMinute = value.Minutes;
			}
		}

		private void btnHourPlus_Click(object sender, EventArgs e)
		{
			if (SelectedHour < 23)
				SelectedHour++;
			else
				SelectedHour = 0;
		}

		private void btnHourMinus_Click(object sender, EventArgs e)
		{
			if (SelectedHour > 0)
				SelectedHour--;
			else
				SelectedHour = 23;
		}

		private void btnMinutePlus_Click(object sender, EventArgs e)
		{
			if (SelectedMinute < 59)
				SelectedMinute++;
			else
				SelectedMinute = 0;
		}

		private void btnMinuteMinus_Click(object sender, EventArgs e)
		{
			if (SelectedMinute > 0)
				SelectedMinute--;
			else
				SelectedMinute = 59;
		}

		private void ctxHour_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
			=> SelectedHour = (int)e.ClickedItem.Tag;

		private void ctxMinute_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
			=> SelectedMinute = (int)e.ClickedItem.Tag;
	}
}
