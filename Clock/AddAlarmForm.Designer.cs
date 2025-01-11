namespace Clock
{
	partial class AddAlarmForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbUseDate = new System.Windows.Forms.CheckBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.lblAlamFile = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnFile = new System.Windows.Forms.Button();
			this.clbWeekDays = new System.Windows.Forms.CheckedListBox();
			this.rtbMessage = new System.Windows.Forms.RichTextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbUseDate
			// 
			this.cbUseDate.AutoSize = true;
			this.cbUseDate.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUseDate.Location = new System.Drawing.Point(13, 13);
			this.cbUseDate.Name = "cbUseDate";
			this.cbUseDate.Size = new System.Drawing.Size(154, 32);
			this.cbUseDate.TabIndex = 0;
			this.cbUseDate.Text = "Use date";
			this.cbUseDate.UseVisualStyleBackColor = true;
			this.cbUseDate.CheckedChanged += new System.EventHandler(this.cbUseDate_CheckedChanged);
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "yyyy/MM/dd";
			this.dtpDate.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(13, 68);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(216, 40);
			this.dtpDate.TabIndex = 1;
			// 
			// dtpTime
			// 
			this.dtpTime.CustomFormat = "hh:mm:ss tt";
			this.dtpTime.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTime.Location = new System.Drawing.Point(281, 68);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.ShowUpDown = true;
			this.dtpTime.Size = new System.Drawing.Size(222, 40);
			this.dtpTime.TabIndex = 2;
			this.dtpTime.Value = new System.DateTime(2024, 12, 26, 21, 48, 13, 0);
			// 
			// lblAlamFile
			// 
			this.lblAlamFile.AutoSize = true;
			this.lblAlamFile.Location = new System.Drawing.Point(12, 221);
			this.lblAlamFile.Name = "lblAlamFile";
			this.lblAlamFile.Size = new System.Drawing.Size(32, 16);
			this.lblAlamFile.TabIndex = 3;
			this.lblAlamFile.Text = "File:";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(313, 254);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(415, 253);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnFile
			// 
			this.btnFile.Location = new System.Drawing.Point(13, 254);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(75, 23);
			this.btnFile.TabIndex = 6;
			this.btnFile.Text = "Choose file";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// clbWeekDays
			// 
			this.clbWeekDays.CheckOnClick = true;
			this.clbWeekDays.ColumnWidth = 42;
			this.clbWeekDays.FormattingEnabled = true;
			this.clbWeekDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.clbWeekDays.Location = new System.Drawing.Point(15, 114);
			this.clbWeekDays.MultiColumn = true;
			this.clbWeekDays.Name = "clbWeekDays";
			this.clbWeekDays.Size = new System.Drawing.Size(488, 38);
			this.clbWeekDays.TabIndex = 7;
			this.clbWeekDays.TabStop = false;
			// 
			// rtbMessage
			// 
			this.rtbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbMessage.Location = new System.Drawing.Point(15, 183);
			this.rtbMessage.Name = "rtbMessage";
			this.rtbMessage.Size = new System.Drawing.Size(488, 26);
			this.rtbMessage.TabIndex = 8;
			this.rtbMessage.Text = "";
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(13, 161);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(141, 16);
			this.lblMessage.TabIndex = 9;
			this.lblMessage.Text = "Введите сообщение:";
			// 
			// AddAlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 301);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.rtbMessage);
			this.Controls.Add(this.clbWeekDays);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblAlamFile);
			this.Controls.Add(this.dtpTime);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.cbUseDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddAlarmForm";
			this.Text = "AddAlarm";
			this.Load += new System.EventHandler(this.AddAlarmForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbUseDate;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.Label lblAlamFile;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.CheckedListBox clbWeekDays;
		private System.Windows.Forms.RichTextBox rtbMessage;
		private System.Windows.Forms.Label lblMessage;
	}
}