using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhenIGetThere
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Use24HourFormat = true;
			dtStartTrip.SelectedDateTime = DateTime.Now;
			dtEndTrip.SelectedDateTime = DateTime.Now.AddDays(1);

			var activitySel = cmbStartActivity.Items;
			activitySel.Add(DriveActivityEnum.Sleeping);
			activitySel.Add(DriveActivityEnum.Break);
			activitySel.Add(DriveActivityEnum.Driving);
			cmbStartActivity.SelectedIndex = 0; 
		}

		private enum DriveActivityEnum : byte
		{
			Driving,
			Break,
			Sleeping,

			Arrived,
		}

		private struct DriveActivityEntry : IComparable<DriveActivityEntry>
		{
			public bool Use24HourFormat;
			public DriveActivityEnum Activity;
			public DateTime StartTimeStamp;
			public double Accumulated;
			public double Traveled;

			public int CompareTo(DriveActivityEntry b) => StartTimeStamp.CompareTo(b.StartTimeStamp);
			public override string ToString()
			{
				const string hour24Format = "ddd, MMM dd @ HH:mm, ";
				const string hour12Format = "ddd, MMM dd @ hh:mm tt, ";

				string time = StartTimeStamp.ToString(Use24HourFormat ? hour24Format : hour12Format);
				string distance = Traveled == 0 ? "" : $" - went {Traveled:0.0} ({Accumulated:0.0})";
				
				return time + Activity.ToString() + distance;
			}
		}

		private static List<DriveActivityEntry> CalculateDriveActivities(in bool use24HourFormat
			, in DriveActivityEnum startActivity, in TimeSpan startActivityTimeRemaining
			, in DateTime startTimeStamp, in TimeSpan sleepTime, in TimeSpan breakTime
			, in TimeSpan driveTime, in double distance, in int averageSpeed)
		{
			// Validate data
			{
				if (!Enum.IsDefined(startActivity))
					throw new ArgumentException($"{typeof(DriveActivityEnum).FullName}.{startActivity} is not supported.", nameof(startActivity));
				if (startActivityTimeRemaining.Ticks < 0)
					throw new ArgumentException("Less than zero.", nameof(startActivityTimeRemaining));
				if (sleepTime.Ticks < 0)
					throw new ArgumentException("Less than zero.", nameof(sleepTime));
				if (breakTime.Ticks < 0)
					throw new ArgumentException("Less than zero.", nameof(breakTime));
				if (driveTime.Ticks < 0)
					throw new ArgumentException("Less than zero.", nameof(driveTime));
				if (distance < 0)
					throw new ArgumentException("Less than zero.", nameof(distance));
				if (averageSpeed <= 0)
					throw new ArgumentException("Less than or equal to zero.", nameof(averageSpeed));
			}

			// Create data list.
			List<DriveActivityEntry> data;
			{
				TimeSpan totalDriveDuration = TimeSpan.FromHours(distance / averageSpeed);
				TimeSpan totalNonDriveDuration = sleepTime + breakTime;

				// Extra 1 is from using Math.Ceiling, but we need that for calculating sleep/break count.
				// Additionally, we add a final entry for 'Arrived' which eliminates the extra.
				int totalDriveEntries = (int)Math.Ceiling(totalDriveDuration / driveTime);
				if (startActivity == DriveActivityEnum.Driving && startActivityTimeRemaining.Ticks > 0)
					totalDriveEntries++;

				int totalNonDriveEntries = totalDriveEntries * 2;
				totalNonDriveEntries += startActivity switch
				{
					DriveActivityEnum.Break => startActivityTimeRemaining.Ticks > 0 ? 2 : 1, // No break time left? only sleep.
					DriveActivityEnum.Sleeping => startActivityTimeRemaining.Ticks > 0 ? 1 : 0, // No time left? immediately start driving.
					DriveActivityEnum.Driving => startActivityTimeRemaining.Ticks > 0 ? 0 : 2, // No drive time left? begin break and sleep.
					_ => 0,
				};

				data = new List<DriveActivityEntry>(totalDriveEntries + totalNonDriveEntries);
			}

			DriveActivityEntry e = new()
			{
				Use24HourFormat = use24HourFormat,
				Activity = startActivity,
				StartTimeStamp = startTimeStamp,
				Accumulated = 0,
				Traveled = 0,
			};

			data.Add(e); // The first entry is the 'start' entry.

			// Handle special second entry.
			if (startActivityTimeRemaining.Ticks > 0)
			{
				switch (startActivity)
				{
					case DriveActivityEnum.Driving:
					{
						e.Activity = DriveActivityEnum.Break;
						e.StartTimeStamp += startActivityTimeRemaining;
						e.Traveled = 0;
						break;
					}

					case DriveActivityEnum.Break:
					{
						e.Activity = DriveActivityEnum.Sleeping;
						e.StartTimeStamp += startActivityTimeRemaining;
						e.Traveled = 0;
						break;
					}

					case DriveActivityEnum.Sleeping:
					{
						e.Activity = DriveActivityEnum.Driving;
						e.StartTimeStamp += startActivityTimeRemaining;
						e.Accumulated += averageSpeed * startActivityTimeRemaining.TotalHours;

						break;
					}

					case DriveActivityEnum.Arrived:
					default: throw new NotSupportedException();
				}

				data.Add(e);
			}
			// No time remaining for first activity, so first entry is actually the next activity.
			else
			{
				e.Activity = startActivity switch
				{
					DriveActivityEnum.Driving => DriveActivityEnum.Break,
					DriveActivityEnum.Break => DriveActivityEnum.Sleeping,
					DriveActivityEnum.Sleeping => DriveActivityEnum.Driving,
					DriveActivityEnum.Arrived => throw new NotSupportedException(),
					_ => throw new NotSupportedException(),
				};

				data[0] = e;
			}

			// Calculate other entries.
			while(e.Accumulated < distance)
			{
				// Using the last activity, calculate the next entry and it's data.
				switch (e.Activity)
				{
					case DriveActivityEnum.Driving:
					{
						e.Activity = DriveActivityEnum.Break;
						e.StartTimeStamp += driveTime; // begins after driving occured.
						e.Traveled = 0;
						break;
					}
					
					case DriveActivityEnum.Break:
					{
						e.Activity = DriveActivityEnum.Sleeping;
						e.StartTimeStamp += breakTime; // begins after break is over.
						e.Traveled = 0;
						break;
					}

					case DriveActivityEnum.Sleeping:
					{
						e.Activity = DriveActivityEnum.Driving;
						e.StartTimeStamp += sleepTime; // begins after sleeping is done.
						e.Traveled = averageSpeed * driveTime.TotalHours;
						e.Accumulated += e.Traveled;

						break;
					}

					case DriveActivityEnum.Arrived:
					default: throw new NotSupportedException();
				}

				data.Add(e);
			}

			// That last entry is over distance. Fix it up, then add 'arrived' entry.
			{
				// fix last entry
				e.Traveled -= e.Accumulated - distance;
				e.Accumulated = distance;
				data[data.Count - 1] = e;

				// 'arrived' entry math
				DateTime finalDrive_StartTime = e.StartTimeStamp;
				TimeSpan finalDrive_Duration = TimeSpan.FromHours(e.Traveled / averageSpeed);

				// 'arrived entry
				e.Activity = DriveActivityEnum.Arrived;
				e.Traveled = 0;
				e.StartTimeStamp = finalDrive_StartTime + finalDrive_Duration;
				data.Add(e);
			}

			return data;
		}

		public bool Use24HourFormat
		{
			get => m_Use24HourFormat;
			set
			{
				if (value ^ m_Use24HourFormat)
				{
					m_Use24HourFormat = value;
					dtStartTrip.Use24HourFormat = value;
					dtEndTrip.Use24HourFormat = value;
				}
			}
		}
		private bool m_Use24HourFormat;

		private void chkUse24HourFormat_CheckedChanged(object sender, EventArgs e)
			=> Use24HourFormat = chkUse24HourFormat.Checked;

		private void cmbStartActivity_SelectedIndexChanged(object sender, EventArgs e)
		{
			var activity = (DriveActivityEnum)cmbStartActivity.SelectedItem;

			durStartActivityRemainingTime.SelectedTime = activity switch
			{
				DriveActivityEnum.Driving => durDriveTime.SelectedTime,
				DriveActivityEnum.Break => durBreakTime.SelectedTime,
				DriveActivityEnum.Sleeping => durSleepTime.SelectedTime,
				DriveActivityEnum.Arrived => throw new NotSupportedException(),
				_ => throw new NotSupportedException(),
			};
		}

		private void btnClearResults_Click(object sender, EventArgs e)
		{
			lblRemainingTime.Text = "";
			lstResults.Items.Clear();
		}

		private void btnCalculateResults_Click(object sender, EventArgs e)
		{
			List<DriveActivityEntry> entries = CalculateDriveActivities(Use24HourFormat
				, (DriveActivityEnum)cmbStartActivity.SelectedItem, durStartActivityRemainingTime.SelectedTime
				, dtStartTrip.SelectedDateTime, durSleepTime.SelectedTime, durBreakTime.SelectedTime
				, durDriveTime.SelectedTime, (double)updownDistanceMiles.Value, (int)updownAvgSpeed.Value);

			for (int i = 0; i < entries.Count; i++)
				lstResults.Items.Add(entries[i]);

			// Extra time (+), owed time (-)
			string remainingTimeText;
			{
				double remaining = (dtEndTrip.SelectedDateTime - entries[entries.Count - 1].StartTimeStamp).TotalHours;
				double hoursRemaining = Math.Round(remaining, MidpointRounding.ToZero);
				double minutesRemaining = Math.Ceiling(Math.Abs(remaining - hoursRemaining) * 60);

				string hoursText = hoursRemaining.ToString("0") + " hrs, ";
				if (remaining > 0) hoursText = '+' + hoursText;

				string minutesText = minutesRemaining.ToString("0") + " mins";

				remainingTimeText = hoursText + minutesText;
			}
			lblRemainingTime.Text = remainingTimeText;
		}
	}
}
