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

namespace Dashboard
{
    public partial class frmCalender : Form
    {
        int month, year;
        public frmCalender()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmCalender_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;



            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year,month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) +1;
            if (dayoftheweek == 0)

            {

                dayoftheweek = 7;

            }

            for (int i=1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }

            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            //HÄR
            
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            if (month == 1)

            {

                month = 12;

                year--;

            }
            month--;

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            if (month == 12)

            {

                month = 0;

                year++;

            }
            month++;

          

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("D")) + 1;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
