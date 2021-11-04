
namespace WhenIGetThere
{
	partial class DateTimeUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblTitle = new System.Windows.Forms.Label();
			this.calDate = new System.Windows.Forms.MonthCalendar();
			this.btnSelectTimeNow = new System.Windows.Forms.Button();
			this.durCtrl = new WhenIGetThere.DurationUserControl();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.Location = new System.Drawing.Point(3, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(34, 17);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Text";
			// 
			// calDate
			// 
			this.calDate.BackColor = System.Drawing.SystemColors.Control;
			this.calDate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.calDate.Location = new System.Drawing.Point(3, 58);
			this.calDate.MaxSelectionCount = 1;
			this.calDate.Name = "calDate";
			this.calDate.ShowWeekNumbers = true;
			this.calDate.TabIndex = 2;
			// 
			// btnSelectTimeNow
			// 
			this.btnSelectTimeNow.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnSelectTimeNow.Location = new System.Drawing.Point(212, 29);
			this.btnSelectTimeNow.Name = "btnSelectTimeNow";
			this.btnSelectTimeNow.Size = new System.Drawing.Size(40, 23);
			this.btnSelectTimeNow.TabIndex = 3;
			this.btnSelectTimeNow.Text = "Now";
			this.btnSelectTimeNow.UseVisualStyleBackColor = true;
			this.btnSelectTimeNow.Click += new System.EventHandler(this.btnSelectTimeNow_Click);
			// 
			// durCtrl
			// 
			this.durCtrl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.durCtrl.Location = new System.Drawing.Point(3, 22);
			this.durCtrl.MaximumSize = new System.Drawing.Size(0, 36);
			this.durCtrl.MinimumSize = new System.Drawing.Size(200, 36);
			this.durCtrl.Name = "durCtrl";
			this.durCtrl.SelectedHour = 0;
			this.durCtrl.SelectedMinute = 0;
			this.durCtrl.SelectedTime = System.TimeSpan.Parse("00:00:00");
			this.durCtrl.Size = new System.Drawing.Size(207, 36);
			this.durCtrl.TabIndex = 4;
			this.durCtrl.Use24HourFormat = false;
			// 
			// TimeStampUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.durCtrl);
			this.Controls.Add(this.btnSelectTimeNow);
			this.Controls.Add(this.calDate);
			this.Controls.Add(this.lblTitle);
			this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.MaximumSize = new System.Drawing.Size(258, 226);
			this.MinimumSize = new System.Drawing.Size(258, 226);
			this.Name = "TimeStampUserControl";
			this.Size = new System.Drawing.Size(256, 224);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.MonthCalendar calDate;
		private System.Windows.Forms.Button btnSelectTimeNow;
		private DurationUserControl durCtrl;
	}
}
