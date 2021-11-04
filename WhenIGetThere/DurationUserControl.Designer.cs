
namespace WhenIGetThere
{
	partial class DurationUserControl
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
			this.components = new System.ComponentModel.Container();
			this.lblMinute = new System.Windows.Forms.Label();
			this.ctxMinute = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.btnMinuteMinus = new System.Windows.Forms.Button();
			this.btnMinutePlus = new System.Windows.Forms.Button();
			this.lblHour = new System.Windows.Forms.Label();
			this.ctxHour = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnHourMinus = new System.Windows.Forms.Button();
			this.btnHourPlus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMinute
			// 
			this.lblMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMinute.ContextMenuStrip = this.ctxMinute;
			this.lblMinute.Location = new System.Drawing.Point(106, 10);
			this.lblMinute.Name = "lblMinute";
			this.lblMinute.Size = new System.Drawing.Size(70, 16);
			this.lblMinute.TabIndex = 5;
			this.lblMinute.Text = "00";
			this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ctxMinute
			// 
			this.ctxMinute.AutoSize = false;
			this.ctxMinute.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ctxMinute.Name = "ctxMinute";
			this.ctxMinute.ShowImageMargin = false;
			this.ctxMinute.Size = new System.Drawing.Size(82, 290);
			this.ctxMinute.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxMinute_ItemClicked);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.ContextMenuStrip = this.ctxMinute;
			this.label4.Location = new System.Drawing.Point(108, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Minute:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinuteMinus
			// 
			this.btnMinuteMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinuteMinus.BackColor = System.Drawing.Color.Firebrick;
			this.btnMinuteMinus.ContextMenuStrip = this.ctxMinute;
			this.btnMinuteMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnMinuteMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.btnMinuteMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.btnMinuteMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinuteMinus.ForeColor = System.Drawing.Color.Black;
			this.btnMinuteMinus.Location = new System.Drawing.Point(176, 17);
			this.btnMinuteMinus.Name = "btnMinuteMinus";
			this.btnMinuteMinus.Size = new System.Drawing.Size(18, 14);
			this.btnMinuteMinus.TabIndex = 7;
			this.btnMinuteMinus.Text = "-";
			this.btnMinuteMinus.UseVisualStyleBackColor = false;
			this.btnMinuteMinus.Click += new System.EventHandler(this.btnMinuteMinus_Click);
			// 
			// btnMinutePlus
			// 
			this.btnMinutePlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinutePlus.BackColor = System.Drawing.Color.ForestGreen;
			this.btnMinutePlus.ContextMenuStrip = this.ctxMinute;
			this.btnMinutePlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnMinutePlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnMinutePlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
			this.btnMinutePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinutePlus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnMinutePlus.ForeColor = System.Drawing.Color.Black;
			this.btnMinutePlus.Location = new System.Drawing.Point(176, 4);
			this.btnMinutePlus.Name = "btnMinutePlus";
			this.btnMinutePlus.Size = new System.Drawing.Size(18, 14);
			this.btnMinutePlus.TabIndex = 6;
			this.btnMinutePlus.Text = "+";
			this.btnMinutePlus.UseVisualStyleBackColor = false;
			this.btnMinutePlus.Click += new System.EventHandler(this.btnMinutePlus_Click);
			// 
			// lblHour
			// 
			this.lblHour.ContextMenuStrip = this.ctxHour;
			this.lblHour.Location = new System.Drawing.Point(8, 10);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(75, 16);
			this.lblHour.TabIndex = 1;
			this.lblHour.Text = "12 AM";
			this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ctxHour
			// 
			this.ctxHour.AutoSize = false;
			this.ctxHour.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ctxHour.Name = "ctxHour";
			this.ctxHour.ShowImageMargin = false;
			this.ctxHour.Size = new System.Drawing.Size(96, 554);
			this.ctxHour.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxHour_ItemClicked);
			// 
			// label1
			// 
			this.label1.ContextMenuStrip = this.ctxHour;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hour:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnHourMinus
			// 
			this.btnHourMinus.BackColor = System.Drawing.Color.Firebrick;
			this.btnHourMinus.ContextMenuStrip = this.ctxHour;
			this.btnHourMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnHourMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
			this.btnHourMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
			this.btnHourMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHourMinus.ForeColor = System.Drawing.Color.Black;
			this.btnHourMinus.Location = new System.Drawing.Point(83, 17);
			this.btnHourMinus.Name = "btnHourMinus";
			this.btnHourMinus.Size = new System.Drawing.Size(18, 14);
			this.btnHourMinus.TabIndex = 3;
			this.btnHourMinus.Text = "-";
			this.btnHourMinus.UseVisualStyleBackColor = false;
			this.btnHourMinus.Click += new System.EventHandler(this.btnHourMinus_Click);
			// 
			// btnHourPlus
			// 
			this.btnHourPlus.BackColor = System.Drawing.Color.ForestGreen;
			this.btnHourPlus.ContextMenuStrip = this.ctxHour;
			this.btnHourPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnHourPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
			this.btnHourPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
			this.btnHourPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHourPlus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnHourPlus.ForeColor = System.Drawing.Color.Black;
			this.btnHourPlus.Location = new System.Drawing.Point(83, 4);
			this.btnHourPlus.Name = "btnHourPlus";
			this.btnHourPlus.Size = new System.Drawing.Size(18, 14);
			this.btnHourPlus.TabIndex = 2;
			this.btnHourPlus.Text = "+";
			this.btnHourPlus.UseVisualStyleBackColor = false;
			this.btnHourPlus.Click += new System.EventHandler(this.btnHourPlus_Click);
			// 
			// DurationUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnMinuteMinus);
			this.Controls.Add(this.btnMinutePlus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnHourMinus);
			this.Controls.Add(this.btnHourPlus);
			this.Controls.Add(this.lblHour);
			this.Controls.Add(this.lblMinute);
			this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.MaximumSize = new System.Drawing.Size(0, 36);
			this.MinimumSize = new System.Drawing.Size(200, 36);
			this.Name = "DurationUserControl";
			this.Size = new System.Drawing.Size(200, 36);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMinute;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnMinuteMinus;
		private System.Windows.Forms.Button btnMinutePlus;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnHourMinus;
		private System.Windows.Forms.Button btnHourPlus;
		private System.Windows.Forms.ContextMenuStrip ctxMinute;
		private System.Windows.Forms.ContextMenuStrip ctxHour;
	}
}
