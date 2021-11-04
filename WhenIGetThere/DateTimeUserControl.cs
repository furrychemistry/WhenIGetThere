using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WhenIGetThere
{
	public partial class DateTimeUserControl : UserControl
	{
		private readonly Calendar m_Cal = CultureInfo.CurrentCulture.Calendar;

		public virtual string Title
		{
			get => lblTitle.Text;
			set => lblTitle.Text = value;
		}

		public override Color ForeColor
		{
			get => base.ForeColor;
			set
			{
				base.ForeColor = value;
				calDate.ForeColor = value;
			}
		}

		public override Color BackColor
		{
			get => base.BackColor;
			set
			{
				base.BackColor = value;
				calDate.BackColor = value;
			}
		}

		public DateTimeUserControl()
		{
			InitializeComponent();

			var txt = Text;
			Text = txt;

			calDate.SetDate(DateTime.Now.Date);
			MinDate = DateTime.Now.Date.AddMonths(-1);
			MaxDate = DateTime.Now.Date.AddMonths(1);

			SelectedDateTime = DateTime.Now;
		}

		public bool Use24HourFormat
		{
			get => durCtrl.Use24HourFormat;
			set => durCtrl.Use24HourFormat = value;
		}

		public int SelectedMinute
		{
			get => durCtrl.SelectedMinute;
			set => durCtrl.SelectedMinute = value;
		}

		public int SelectedHour
		{
			get => durCtrl.SelectedHour;
			set => durCtrl.SelectedHour = value;
		}

		public int SelectedDay
		{
			get => calDate.SelectionStart.Day;
			set
			{

				DateTime v = SelectedDate;
				SelectedDate = new DateTime(v.Year, v.Month, Math.Clamp(value, 1, m_Cal.GetDaysInMonth(v.Year, v.Month)));
			}
		}

		public int SelectedMonth
		{
			get => calDate.SelectionStart.Month;
			set
			{

				DateTime v = SelectedDate;
				SelectedDate = new DateTime(v.Year, Math.Clamp(value, 1, 12), v.Day);
			}
		}

		public int SelectedYear
		{
			get => calDate.SelectionStart.Year;
			set
			{
				DateTime v = SelectedDate;
				SelectedDate = new DateTime(value, v.Month, v.Day);
			}
		}

		public TimeSpan SelectedTime
		{
			get => durCtrl.SelectedTime;
			set => durCtrl.SelectedTime = value;
		}

		public DateTime SelectedDate
		{
			get => calDate.SelectionStart;
			set
			{
				DateTime min = calDate.MinDate;
				DateTime max = calDate.MaxDate;

				calDate.SelectionStart = (value < min ? min : (value > max ? max : value)).Date;
			}
		}

		public DateTime SelectedDateTime
		{
			get => SelectedDate + SelectedTime;
			set
			{
				DateTime date = value.Date;
				SelectedDate = date;
				SelectedTime = value - date;
			}
		}

		public DateTime MinDate
		{
			get => calDate.MinDate;
			set => calDate.MinDate = value.Date;
		}

		public DateTime MaxDate
		{
			get => calDate.MaxDate;
			set => calDate.MaxDate = value.Date;
		}

		public Size CalendarDimensions
		{
			get => calDate.CalendarDimensions;
			set
			{
				Size beforeResize = calDate.Size;
				calDate.CalendarDimensions = value;

				// of course, resize doesn't work right...
				{
					//Size newSize = calDate.Size - beforeResize;
					//Size oldSize = Size;

					//if (newSize == oldSize)
					//	return;

					////SuspendLayout();

					//// Using both old and new sizes, set min to the smallest width/height combo,
					//// set max to max possible combo, set new size, then set min/max to new size.
					//Size minSizeCombo = new(Math.Min(newSize.Width, oldSize.Width), Math.Min(newSize.Height, oldSize.Height));
					//Size maxSizeCombo = new(Math.Max(newSize.Width, oldSize.Width), Math.Max(newSize.Height, oldSize.Height));

					//MinimumSize = minSizeCombo;
					//MaximumSize = maxSizeCombo;
					//Size = newSize;
					//MinimumSize = newSize;
					//MaximumSize = newSize;

					////ResumeLayout(false);
				}
			}
		}

		private void btnSelectTimeNow_Click(object sender, EventArgs e)
			=> SelectedTime = DateTime.Now - DateTime.Now.Date;
	}
}
