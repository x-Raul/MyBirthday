using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBirthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime endTime = new DateTime(2021, 4, 24, 0, 0, 0);
            DateTime NowTime = DateTime.Now;
            var yearsold = 0;
            while (endTime <= NowTime)
            {
                endTime = endTime.AddYears(1);
            }
            if(NowTime.Month == 4 && NowTime.Day == 24)
            {
                yearsold = (NowTime.Year - 2001) -1;
            }
            else
            {
                yearsold = NowTime.Year - 2001;
            }
            TimeSpan ts = endTime.Subtract(NowTime);
            byears.Text = "My Birthday #" + yearsold;
            d.Text = ts.Days.ToString();
            h.Text = ts.Hours.ToString();
            m.Text = ts.Minutes.ToString();
            s.Text = ts.Seconds.ToString();
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
