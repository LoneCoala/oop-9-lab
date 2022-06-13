using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_9_lab
{
    public partial class TimeManagment : Form
    {
        public TimeManagment()
        {
            InitializeComponent();

        }
        TimeFinallization timeFinallization = new TimeFinallization();

        public Time Min(Time p1, Time p2)
        {
            int sum1, sum2, sum;
            sum1 = p1.hour * 60 + p1.minutes;
            sum2 = p2.hour * 60 + p2.minutes;
            sum = sum2 - sum1;
            Time o = new Time();
            o.hour = sum / 60;
            o.minutes = sum % 60;
            return o;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Time mor = new Time(), timeM1 = new Time(), timeM2 = new Time(), timeA1 = new Time(), timeA2 = new Time(), timeE1 = new Time(), timeE2 = new Time(), night = new Time();
            string pr = "";
            int hour;
            timeA1.hour = 24;
            timeE1.hour = 24;
            timeM1.hour = 24;
            night.hour = 24;
            int j = 0;
            for (int i = 0; i < ListBox.CheckedItems.Count; i++)
            {
                MessageBox.Show(i+" строка работает "+ ListBox.CheckedItems.Count);
                string s = ListBox.CheckedItems[i].ToString();
                s += " ";
                for (j = 0; j <= s.Length - 1; j++)
                {
                    if (s[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    pr = "";
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    if (s[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    pr = "";
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    if (s[j] == ' ')
                    {
                        j++;
                        break;
                    }
                    pr = "";
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= mor.hour)
                        {
                            MessageBox.Show(pr);
                            int.TryParse(pr, out mor.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= mor.hour)
                        {
                            int.TryParse(pr, out mor.minutes);
                            break;
                            pr = "";
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    //if (s[j] == '0')
                    //{
                    //    timeA1.hour = mor.hour;
                    //    break;
                    //}
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeM1.hour)
                        {
                            MessageBox.Show(pr);
                            int.TryParse(pr, out timeM1.hour);
                            pr = "";
                            break;
                            
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    //if (s[j-2] == '0')
                    //{
                    //    timeA1.minutes = mor.minutes;
                    //    break;
                    //}
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeM1.hour)
                        {
                            int.TryParse(pr, out timeM1.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeM2.hour)
                        {
                            MessageBox.Show("3 работает");
                            int.TryParse(pr, out timeM2.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeM2.hour)
                        {

                            int.TryParse(pr, out timeM2.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeA1.hour)
                        {                           
                            MessageBox.Show("4 работает");
                            int.TryParse(pr, out timeA1.hour);
                            pr = "";
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeA1.hour)
                        {
                            int.TryParse(pr, out timeA1.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeA2.hour)
                        {
                            MessageBox.Show("5 работает");
                            int.TryParse(pr, out timeA2.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeA2.hour)
                        {
                            int.TryParse(pr, out timeA2.minutes);
                            pr = "";
                            break;
                        }
                        else break;
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeE1.hour)
                        {
                            MessageBox.Show("6 работает");
                            int.TryParse(pr, out timeE1.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeE1.hour)
                        {
                            int.TryParse(pr, out timeE1.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeE2.hour)
                        {
                            MessageBox.Show("7 работает");
                            int.TryParse(pr, out timeE2.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeE2.hour)
                        {
                            int.TryParse(pr, out timeE2.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j+2; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= night.hour)
                        {
                            MessageBox.Show("8 работает");
                            int.TryParse(pr, out night.hour);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ' ')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= night.hour)
                        {
                            int.TryParse(pr, out night.minutes);
                            pr = "";
                            break;
                        }
                        else
                        {
                            pr = "";
                            break;
                        }
                    }
                }

            }
            MessageBox.Show(mor.hour + " " + timeM1.hour + night.hour);
            Time final = new Time();
            final = Min(mor, night);
            MessageBox.Show(final.hour.ToString());
           
            if (timeM1.hour != 0)
                {
                    final = Min(mor, timeM1);
                    if (final.hour != 0)
                    {
                    MessageBox.Show(mor.hour + " " + timeM1.hour);
                    timeFinallization.textBox1.Text += "Встреча возможна с " + mor.hour + ":" + mor.minutes + " до " + timeM1.hour + ":" + timeM1.minutes;
                    }
                }
                else if (timeA1.hour != 0)
                {
                    final = Min(mor, timeA1);
                    if (final.hour != 0)
                    {
                    MessageBox.Show(mor.hour + " " + timeA1.hour + " " + final.hour);
                    timeFinallization.textBox1.Text += "Встреча возможна с " + mor.hour + ":" + mor.minutes + " до " + timeA1.hour + ":" + timeA1.minutes;
                    }
                }
                else if (timeE1.hour != 0)
                {
                    final = Min(mor, timeE1);
                    if (final.hour != 0)
                    {
                    MessageBox.Show(mor.hour + " " + timeE1.hour + " " + final.hour);
                    timeFinallization.textBox1.Text += "Встреча возможна с " + mor.hour + ":" + mor.minutes + " до " + timeE1.hour + ":" + timeE1.minutes;
                    timeFinallization.ShowDialog();
                }
                }
                else
                {
                    final = Min(mor, night);
                    if (final.hour != 0)
                    {
                    MessageBox.Show(mor.hour + " " + night.hour + " " + final.hour);
                    timeFinallization.textBox1.Text += "Встреча возможна с " + mor.hour + ":" + mor.minutes + " до " + night.hour + ":" + night.minutes;
                    }
                }
                final = Min(timeM2, timeA1);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeM2.hour + ":" + timeM2.minutes + " до " + timeA1.hour + ":" + timeA1.minutes;
                }
                final= Min(timeA2, timeE1);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeA2.hour + ":" + timeA2.minutes + " до " + timeE1.hour + ":" + timeE1.minutes;
                }
                final = Min(timeE2, night);
                if (final.hour != 0)
                {
                
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeE2.hour + ":" + timeE2.minutes + " до " + night.hour + ":" + night.minutes;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
