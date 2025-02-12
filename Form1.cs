using System.Globalization;

namespace WhatTimeIsIn
{
    public partial class Form1 : Form
    {
        private TimeZoneService? _timeZoneService;

        public Form1()
        {
            InitializeComponent();
            _timeZoneService = new TimeZoneService();
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
            var localDate = _timeZoneService.GetLocalDateById("E. Australia Standard Time");

            lblTime2.Text = localDate.ToString("HH:mm");
            lblTicks2.Text = localDate.ToString("ss");
            lblDate2.Text = localDate.ToString("dd MMM yyyy");
            lblDay2.Text = localDate.ToString("dddd").ToUpper();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var localDate = _timeZoneService.GetLocalDateById("Tokyo Standard Time");

            lblTime3.Text = localDate.ToString("HH:mm");
            lblTicks3.Text = localDate.ToString("ss");
            lblDate3.Text = localDate.ToString("dd MMM yyyy");
            lblDay3.Text = localDate.ToString("dddd").ToUpper();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            var localDate = _timeZoneService.GetLocalDateById("Russian Standard Time");

            lblTime4.Text = localDate.ToString("HH:mm");
            lblTicks4.Text = localDate.ToString("ss");
            lblDate4.Text = localDate.ToString("dd MMM yyyy");
            lblDay4.Text = localDate.ToString("dddd").ToUpper();
        }
    }
}
