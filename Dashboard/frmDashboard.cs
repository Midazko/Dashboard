using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            Weatherdisplay();
            APIhelper.InitializeClient();
        }
        private async void Weatherdisplay()
        {
            Webmodelresult? weatherinfo;
            weatherinfo = await WebProccesor.LoadWeb();
            label_weather.Text = $"Temprature in Motala: {Weatherstring(weatherinfo, "t")}°C";
        }
        public static string Weatherstring(Webmodelresult weatherInfo, string temp)
        {
            var parameter = weatherInfo.TimeSeries[0].Parameters.FirstOrDefault(parameters => parameters.Name == temp);
            return parameter.Values[0];
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width -5, lblSecond.Location.Y);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            timer.Start();
        }
    }
}

