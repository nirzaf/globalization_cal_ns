using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace globalization_cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.Globalization.GregorianCalendar g = new System.Globalization.GregorianCalendar();
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.yesr_textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.day_textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.day_week_textBox1.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            //------------------------------------
            Int32 m;
            Int32.TryParse(this.month_textBox2.Text, out m);
            //------------------------------------
            this.month_namelabel4.Text = month_num_to_name(m);
        }

        //------------------------
        public string month_num_to_name(Int32 month_num)
        {
            string mn;

            switch (month_num)
            {

                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break;

                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;

                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;

                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unknown";
                    break;
            }

            return mn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.cal_year_numlabel5.Text = g.GetYear(DateTime.Now).ToString();
           // this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.cal_day_in_monthlabel7.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.cal_day_in_weeklabel8.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            //------------------------------------
            Int32 m;
            string mnum;
            mnum = g.GetMonth(DateTime.Now).ToString();
            Int32.TryParse(mnum , out m);
            //------------------------------------
            this.cal_month_namelabel6.Text = month_num_to_name(m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Globalization.HijriCalendar g;
            g = new System.Globalization.HijriCalendar();
            
            this.yesr_textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.day_textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.day_week_textBox1.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            if (g.GetDayOfWeek(DateTime.Now)==DayOfWeek.Friday)
            {
                this.day_week_textBox1.Text = "assa";
            }
            //------------------------------------
            Int32 m;
            Int32.TryParse(this.month_textBox2.Text, out m);
            //------------------------------------
            this.month_namelabel4.Text = month_num_to_name(m);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Globalization.JapaneseCalendar g;
            g = new System.Globalization.JapaneseCalendar();

            this.yesr_textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.day_textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.day_week_textBox1.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            if (g.GetDayOfWeek(DateTime.Now) == DayOfWeek.Friday)
            {
                this.day_week_textBox1.Text = "jap";
            }
            //------------------------------------
            Int32 m;
            Int32.TryParse(this.month_textBox2.Text, out m);
            //------------------------------------
            this.month_namelabel4.Text = month_num_to_name(m);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Globalization.PersianCalendar g;
            g = new System.Globalization.PersianCalendar();

            this.yesr_textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.day_textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.day_week_textBox1.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            if (g.GetDayOfWeek(DateTime.Now) == DayOfWeek.Friday)
            {
                this.day_week_textBox1.Text = "jap";
            }
            //------------------------------------
            Int32 m;
            Int32.TryParse(this.month_textBox2.Text, out m);
            //------------------------------------
            this.month_namelabel4.Text = month_num_to_name(m);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Globalization.KoreanCalendar g;
            g = new System.Globalization.KoreanCalendar();
           
            this.yesr_textBox1.Text = g.GetYear(DateTime.Now).ToString();
            this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.day_textBox3.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.day_week_textBox1.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            if (g.GetDayOfWeek(DateTime.Now) == DayOfWeek.Friday)
            {
                this.day_week_textBox1.Text = "jap";
            }
            //------------------------------------
            Int32 m;
            Int32.TryParse(this.month_textBox2.Text, out m);
            //------------------------------------
            this.month_namelabel4.Text = month_num_to_name(m);
        }
        //------------------------

    }
}
