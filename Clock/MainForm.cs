using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
		
		}
		void SetVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
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
			if (cbShowWeekDay.Checked)
			{
				labelTime.Text += "\n";
				labelTime.Text += DateTime.Now.DayOfWeek;
			}
			notifyIcon.Text = "";
			notifyIcon.Text = labelTime.Text;
		}
		private void btnHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(false);
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
			SetVisibility(true);
		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
