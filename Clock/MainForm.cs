﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clock
{
	public partial class MainForm : Form
	{
		
		ChooseFontForm fontDialog =null;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.Black;
			labelTime.ForeColor = Color.Red;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			SetVisibility(false);
			cmShowConsole.Checked = true;
			fontDialog = new ChooseFontForm();
		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			cbShowWeekday.Visible = visible;
			btnHideControls.Visible = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture); //"HH:mm:ss" В 24 часовом формате
																													  // https://learn.microsoft.com/ru-ru/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-8.0
			if (cbShowDate.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.ToString("yyyy.MM.dd");//"d"  дата по умолчанию
			}
			if (cbShowWeekday.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
		
			notifyIcon.Text = labelTime.Text;
		}
		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(cmShowControls.Checked=false);
			//cmShowControls.Checked = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			//MessageBox.Show
			//	(this,
			//	"Вы два раза щелкнули мышью по времени. и теперь вы управляете временем",
			//	"info",
			//	MessageBoxButtons.OK,
			//	MessageBoxIcon.Information
			//	);
			SetVisibility(cmShowControls.Checked=true);
		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void cmExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cmTopmost_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost= cmTopmost.Checked;
		}

		private void cmShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cbShowDate.Checked = cmShowDate.Checked;
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			cmShowDate.Checked = cbShowDate.Checked;
		}

		private void cmShowWeekday_CheckedChanged(object sender, EventArgs e)
		{
			cbShowWeekday.Checked = cmShowWeekday.Checked;	
		}

		private void cbShowWeekDay_CheckedChanged(object sender, EventArgs e)
		{
			cmShowWeekday.Checked = cbShowWeekday.Checked;
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;

			}
		}

		private void cmShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(cmShowControls.Checked);

		}

		private void SetColor(object sender, EventArgs e)
		{
			ColorDialog dialog= new ColorDialog();
			//dialog.Color = labelTime.BackColor;
			switch ((sender as ToolStripMenuItem).Text)//as -это оператор преобразования типа
			//switch(((ToolStripMenuItem)sender)
				//Оператор 'as' значение слева приводит к типу справа
			
			{
				case "Background color":   dialog.Color=labelTime.BackColor; break;
				case "Foreground color":   dialog.Color= labelTime.ForeColor; break;
			}

			if (dialog.ShowDialog() == DialogResult.OK)
			{ 
				switch((sender as ToolStripMenuItem).Text)
				{
					case "Background color":labelTime.BackColor=dialog.Color; break;
					case "Foreground color":labelTime.ForeColor=dialog.Color; break;
				}
			}
		}

		private void cmChooseFont_Click(object sender, EventArgs e)
		{
			if(fontDialog.ShowDialog()==DialogResult.OK)
				labelTime.Font=fontDialog.Font;
		}

		private void cmShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			if ((sender as ToolStripMenuItem).Checked)
				AllocConsole();
			else
				FreeConsole();
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		[DllImport ("kernel32.dll")]
		public static extern bool FreeConsole();

		//smallCamel
		//BigCamel
		//snake_case
		//SNAKE_CASE
	}
}
