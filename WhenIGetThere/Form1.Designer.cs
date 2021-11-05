
namespace WhenIGetThere
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstResults = new System.Windows.Forms.ListBox();
			this.dtStartTrip = new WhenIGetThere.DateTimeUserControl();
			this.dtEndTrip = new WhenIGetThere.DateTimeUserControl();
			this.chkUse24HourFormat = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.durSleepTime = new WhenIGetThere.DurationUserControl();
			this.durBreakTime = new WhenIGetThere.DurationUserControl();
			this.label4 = new System.Windows.Forms.Label();
			this.updownDistanceMiles = new System.Windows.Forms.NumericUpDown();
			this.updownAvgSpeed = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.durDriveTime = new WhenIGetThere.DurationUserControl();
			this.btnCalculateResults = new System.Windows.Forms.Button();
			this.btnClearResults = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lblRemainingTime = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.durStartActivityRemainingTime = new WhenIGetThere.DurationUserControl();
			this.cmbStartActivity = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.updownDistanceMiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updownAvgSpeed)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstResults
			// 
			this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstResults.FormattingEnabled = true;
			this.lstResults.HorizontalScrollbar = true;
			this.lstResults.ItemHeight = 15;
			this.lstResults.Location = new System.Drawing.Point(503, 12);
			this.lstResults.Name = "lstResults";
			this.lstResults.ScrollAlwaysVisible = true;
			this.lstResults.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lstResults.Size = new System.Drawing.Size(313, 454);
			this.lstResults.TabIndex = 11;
			// 
			// dtStartTrip
			// 
			this.dtStartTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dtStartTrip.CalendarDimensions = new System.Drawing.Size(1, 1);
			this.dtStartTrip.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtStartTrip.Location = new System.Drawing.Point(12, 12);
			this.dtStartTrip.MaxDate = new System.DateTime(2021, 12, 3, 0, 0, 0, 0);
			this.dtStartTrip.MaximumSize = new System.Drawing.Size(258, 226);
			this.dtStartTrip.MinDate = new System.DateTime(2021, 10, 3, 0, 0, 0, 0);
			this.dtStartTrip.MinimumSize = new System.Drawing.Size(258, 226);
			this.dtStartTrip.Name = "dtStartTrip";
			this.dtStartTrip.SelectedDate = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
			this.dtStartTrip.SelectedDateTime = new System.DateTime(2021, 11, 3, 0, 54, 0, 0);
			this.dtStartTrip.SelectedDay = 3;
			this.dtStartTrip.SelectedHour = 0;
			this.dtStartTrip.SelectedMinute = 54;
			this.dtStartTrip.SelectedMonth = 11;
			this.dtStartTrip.SelectedTime = System.TimeSpan.Parse("00:54:00");
			this.dtStartTrip.SelectedYear = 2021;
			this.dtStartTrip.Size = new System.Drawing.Size(258, 226);
			this.dtStartTrip.TabIndex = 0;
			this.dtStartTrip.Title = "Start";
			this.dtStartTrip.Use24HourFormat = false;
			// 
			// dtEndTrip
			// 
			this.dtEndTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dtEndTrip.CalendarDimensions = new System.Drawing.Size(1, 1);
			this.dtEndTrip.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dtEndTrip.Location = new System.Drawing.Point(12, 244);
			this.dtEndTrip.MaxDate = new System.DateTime(2021, 12, 3, 0, 0, 0, 0);
			this.dtEndTrip.MaximumSize = new System.Drawing.Size(258, 226);
			this.dtEndTrip.MinDate = new System.DateTime(2021, 10, 3, 0, 0, 0, 0);
			this.dtEndTrip.MinimumSize = new System.Drawing.Size(258, 226);
			this.dtEndTrip.Name = "dtEndTrip";
			this.dtEndTrip.SelectedDate = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
			this.dtEndTrip.SelectedDateTime = new System.DateTime(2021, 11, 3, 0, 55, 0, 0);
			this.dtEndTrip.SelectedDay = 3;
			this.dtEndTrip.SelectedHour = 0;
			this.dtEndTrip.SelectedMinute = 55;
			this.dtEndTrip.SelectedMonth = 11;
			this.dtEndTrip.SelectedTime = System.TimeSpan.Parse("00:55:00");
			this.dtEndTrip.SelectedYear = 2021;
			this.dtEndTrip.Size = new System.Drawing.Size(258, 226);
			this.dtEndTrip.TabIndex = 1;
			this.dtEndTrip.Title = "End";
			this.dtEndTrip.Use24HourFormat = false;
			// 
			// chkUse24HourFormat
			// 
			this.chkUse24HourFormat.AutoSize = true;
			this.chkUse24HourFormat.Checked = true;
			this.chkUse24HourFormat.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkUse24HourFormat.Location = new System.Drawing.Point(278, 443);
			this.chkUse24HourFormat.Name = "chkUse24HourFormat";
			this.chkUse24HourFormat.Size = new System.Drawing.Size(112, 20);
			this.chkUse24HourFormat.TabIndex = 9;
			this.chkUse24HourFormat.Text = "24 hour format";
			this.chkUse24HourFormat.UseVisualStyleBackColor = true;
			this.chkUse24HourFormat.CheckedChanged += new System.EventHandler(this.chkUse24HourFormat_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sleep:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Break and refueling:";
			// 
			// durSleepTime
			// 
			this.durSleepTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.durSleepTime.Location = new System.Drawing.Point(3, 19);
			this.durSleepTime.MaximumSize = new System.Drawing.Size(0, 36);
			this.durSleepTime.MinimumSize = new System.Drawing.Size(200, 36);
			this.durSleepTime.Name = "durSleepTime";
			this.durSleepTime.SelectedHour = 10;
			this.durSleepTime.SelectedMinute = 0;
			this.durSleepTime.SelectedTime = System.TimeSpan.Parse("10:00:00");
			this.durSleepTime.Size = new System.Drawing.Size(200, 36);
			this.durSleepTime.TabIndex = 1;
			this.durSleepTime.Use24HourFormat = true;
			// 
			// durBreakTime
			// 
			this.durBreakTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.durBreakTime.Location = new System.Drawing.Point(3, 19);
			this.durBreakTime.MaximumSize = new System.Drawing.Size(0, 36);
			this.durBreakTime.MinimumSize = new System.Drawing.Size(200, 36);
			this.durBreakTime.Name = "durBreakTime";
			this.durBreakTime.SelectedHour = 0;
			this.durBreakTime.SelectedMinute = 50;
			this.durBreakTime.SelectedTime = System.TimeSpan.Parse("00:50:00");
			this.durBreakTime.Size = new System.Drawing.Size(200, 36);
			this.durBreakTime.TabIndex = 1;
			this.durBreakTime.Use24HourFormat = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Distance:";
			// 
			// updownDistanceMiles
			// 
			this.updownDistanceMiles.Location = new System.Drawing.Point(83, 4);
			this.updownDistanceMiles.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.updownDistanceMiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updownDistanceMiles.Name = "updownDistanceMiles";
			this.updownDistanceMiles.Size = new System.Drawing.Size(57, 23);
			this.updownDistanceMiles.TabIndex = 1;
			this.updownDistanceMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.updownDistanceMiles.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
			// 
			// updownAvgSpeed
			// 
			this.updownAvgSpeed.Location = new System.Drawing.Point(83, 33);
			this.updownAvgSpeed.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.updownAvgSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updownAvgSpeed.Name = "updownAvgSpeed";
			this.updownAvgSpeed.Size = new System.Drawing.Size(57, 23);
			this.updownAvgSpeed.TabIndex = 3;
			this.updownAvgSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.updownAvgSpeed.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(3, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Avg speed:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(3, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Driving:";
			// 
			// durDriveTime
			// 
			this.durDriveTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.durDriveTime.Location = new System.Drawing.Point(3, 19);
			this.durDriveTime.MaximumSize = new System.Drawing.Size(0, 36);
			this.durDriveTime.MinimumSize = new System.Drawing.Size(200, 36);
			this.durDriveTime.Name = "durDriveTime";
			this.durDriveTime.SelectedHour = 10;
			this.durDriveTime.SelectedMinute = 0;
			this.durDriveTime.SelectedTime = System.TimeSpan.Parse("10:00:00");
			this.durDriveTime.Size = new System.Drawing.Size(200, 36);
			this.durDriveTime.TabIndex = 1;
			this.durDriveTime.Use24HourFormat = true;
			// 
			// btnCalculateResults
			// 
			this.btnCalculateResults.Location = new System.Drawing.Point(429, 305);
			this.btnCalculateResults.Name = "btnCalculateResults";
			this.btnCalculateResults.Size = new System.Drawing.Size(69, 63);
			this.btnCalculateResults.TabIndex = 7;
			this.btnCalculateResults.Text = "Calculate";
			this.btnCalculateResults.UseVisualStyleBackColor = true;
			this.btnCalculateResults.Click += new System.EventHandler(this.btnCalculateResults_Click);
			// 
			// btnClearResults
			// 
			this.btnClearResults.Location = new System.Drawing.Point(395, 434);
			this.btnClearResults.Name = "btnClearResults";
			this.btnClearResults.Size = new System.Drawing.Size(103, 36);
			this.btnClearResults.TabIndex = 10;
			this.btnClearResults.Text = "Clear Results";
			this.btnClearResults.UseVisualStyleBackColor = true;
			this.btnClearResults.Click += new System.EventHandler(this.btnClearResults_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(3, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Extra (+) or owed (-) time";
			// 
			// lblRemainingTime
			// 
			this.lblRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRemainingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRemainingTime.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.lblRemainingTime.Location = new System.Drawing.Point(3, 24);
			this.lblRemainingTime.Name = "lblRemainingTime";
			this.lblRemainingTime.Size = new System.Drawing.Size(213, 26);
			this.lblRemainingTime.TabIndex = 1;
			this.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(3, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(111, 17);
			this.label8.TabIndex = 2;
			this.label8.Text = "Time remaining:";
			// 
			// durStartActivityRemainingTime
			// 
			this.durStartActivityRemainingTime.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.durStartActivityRemainingTime.Location = new System.Drawing.Point(16, 62);
			this.durStartActivityRemainingTime.MaximumSize = new System.Drawing.Size(0, 36);
			this.durStartActivityRemainingTime.MinimumSize = new System.Drawing.Size(200, 36);
			this.durStartActivityRemainingTime.Name = "durStartActivityRemainingTime";
			this.durStartActivityRemainingTime.SelectedHour = 10;
			this.durStartActivityRemainingTime.SelectedMinute = 0;
			this.durStartActivityRemainingTime.SelectedTime = System.TimeSpan.Parse("10:00:00");
			this.durStartActivityRemainingTime.Size = new System.Drawing.Size(200, 36);
			this.durStartActivityRemainingTime.TabIndex = 3;
			this.durStartActivityRemainingTime.Use24HourFormat = true;
			// 
			// cmbStartActivity
			// 
			this.cmbStartActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStartActivity.FormattingEnabled = true;
			this.cmbStartActivity.Location = new System.Drawing.Point(102, 8);
			this.cmbStartActivity.Name = "cmbStartActivity";
			this.cmbStartActivity.Size = new System.Drawing.Size(114, 23);
			this.cmbStartActivity.TabIndex = 1;
			this.cmbStartActivity.SelectedIndexChanged += new System.EventHandler(this.cmbStartActivity_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(3, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "Start activity:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.durStartActivityRemainingTime);
			this.panel1.Controls.Add(this.cmbStartActivity);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(276, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(221, 100);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.durSleepTime);
			this.panel2.Location = new System.Drawing.Point(276, 118);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(221, 57);
			this.panel2.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.durBreakTime);
			this.panel3.Location = new System.Drawing.Point(276, 181);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(221, 57);
			this.panel3.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.durDriveTime);
			this.panel4.Location = new System.Drawing.Point(276, 243);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(221, 57);
			this.panel4.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.updownDistanceMiles);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.updownAvgSpeed);
			this.panel5.Location = new System.Drawing.Point(276, 306);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(147, 61);
			this.panel5.TabIndex = 6;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.lblRemainingTime);
			this.panel6.Location = new System.Drawing.Point(276, 373);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(221, 55);
			this.panel6.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(828, 484);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnClearResults);
			this.Controls.Add(this.btnCalculateResults);
			this.Controls.Add(this.chkUse24HourFormat);
			this.Controls.Add(this.dtEndTrip);
			this.Controls.Add(this.dtStartTrip);
			this.Controls.Add(this.lstResults);
			this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "Form1";
			this.Text = "When I Get There";
			((System.ComponentModel.ISupportInitialize)(this.updownDistanceMiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updownAvgSpeed)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstResults;
		private DateTimeUserControl dtStartTrip;
		private DateTimeUserControl dtEndTrip;
		private System.Windows.Forms.CheckBox chkUse24HourFormat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private DurationUserControl durSleepTime;
		private DurationUserControl durBreakTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown updownDistanceMiles;
		private System.Windows.Forms.NumericUpDown updownAvgSpeed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private DurationUserControl durDriveTime;
		private System.Windows.Forms.Button btnCalculateResults;
		private System.Windows.Forms.Button btnClearResults;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblRemainingTime;
		private System.Windows.Forms.Label label8;
		private DurationUserControl durStartActivityRemainingTime;
		private System.Windows.Forms.ComboBox cmbStartActivity;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
	}
}

