using System.Globalization;

namespace WhatTimeIsIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime1.Text = DateTime.Now.ToString("HH:mm");
            lblTicks1.Text = DateTime.Now.ToString("ss");
            lblDate1.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay1.Text = DateTime.Now.ToString("dddd").ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var tZone = TimeZoneInfo.FindSystemTimeZoneById("E. Australia Standard Time");
            var australiaDate = TimeZoneInfo.ConvertTime(DateTime.Now, tZone);

            lblTime2.Text = australiaDate.ToString("HH:mm");
            lblTicks2.Text = australiaDate.ToString("ss");
            lblDate2.Text = australiaDate.ToString("dd MMM yyyy");
            lblDay2.Text = australiaDate.ToString("dddd").ToUpper();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var tZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            var tokyoDate = TimeZoneInfo.ConvertTime(DateTime.Now, tZone);

            lblTime3.Text = tokyoDate.ToString("HH:mm");
            lblTicks3.Text = tokyoDate.ToString("ss");
            lblDate3.Text = tokyoDate.ToString("dd MMM yyyy");
            lblDay3.Text = tokyoDate.ToString("dddd").ToUpper();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var tZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            var russiaDate = TimeZoneInfo.ConvertTime(DateTime.Now, tZone);

            lblTime4.Text = russiaDate.ToString("HH:mm");
            lblTicks4.Text = russiaDate.ToString("ss");
            lblDate4.Text = russiaDate.ToString("dd MMM yyyy");
            lblDay4.Text = russiaDate.ToString("dddd").ToUpper();
        }
    }
}
