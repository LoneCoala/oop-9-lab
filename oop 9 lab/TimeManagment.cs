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


        private void button1_Click(object sender, EventArgs e)
        {
            Time mor = new Time(), timeM1 = new Time(), timeM2 = new Time(), timeA1 = new Time(), timeA2 = new Time(), timeE1 = new Time(), timeE2 = new Time(), night = new Time();
            string pr = "0";
            int hour;
            timeA1.hour = 24;
            timeE1.hour = 24;
            timeM1.hour = 24;
            night.hour = 24;
            int j = 0;
            for (int i = 0; i < ListBox.CheckedItems.Count; i++)
            {
                string s = ListBox.CheckedItems[i].ToString();
                s += " ";
                for (j = 0; j <= s.Length - 1; j++)
                {
                    if (s[j] == ' ')
                    {
                        j++;
                        break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    if (s[j] == ' ')
                    {
                        j++;
                        break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= mor.hour)
                        {
                            int.TryParse(pr, out mor.hour);
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
                        if (hour >= mor.hour)
                        {
                            int.TryParse(pr, out mor.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeM1.hour)
                        {
                            int.TryParse(pr, out timeM1.hour);
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
                        if (hour <= timeM1.hour)
                        {
                            int.TryParse(pr, out timeM1.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeM2.hour)
                        {
                            int.TryParse(pr, out timeM2.hour);
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
                        if (hour >= timeM2.hour)
                        {
                            int.TryParse(pr, out timeM2.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeA1.hour)
                        {
                            int.TryParse(pr, out timeA1.hour);
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
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeA2.hour)
                        {
                            int.TryParse(pr, out timeA2.hour);
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
                        if (hour >= timeA2.hour)
                        {
                            int.TryParse(pr, out timeA2.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= timeE1.hour)
                        {
                            int.TryParse(pr, out timeE1.hour);
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
                        if (hour <= timeE1.hour)
                        {
                            int.TryParse(pr, out timeE1.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour >= timeE2.hour)
                        {
                            int.TryParse(pr, out timeE2.hour);
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
                        if (hour >= timeE2.hour)
                        {
                            int.TryParse(pr, out timeE2.minutes);
                            break;
                        }
                        else break;
                    }
                }
                for (j = j; j <= s.Length - 1; j++)
                {
                    pr += s[j].ToString();
                    if (s[j + 1] == ':')
                    {
                        int.TryParse(pr, out hour);
                        if (hour <= night.hour)
                        {
                            int.TryParse(pr, out night.hour);
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
                        if (hour <= night.hour)
                        {
                            int.TryParse(pr, out night.minutes);
                            break;
                        }
                        else break;
                    }
                }
                Time final = new Time();
                final.FreeTime(mor, timeM1);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + mor.hour + ":" + mor.minutes +" до " + timeM1.hour + ":" + timeM1.minutes;
                }
                final.FreeTime(timeM2, timeA1);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeM2.hour + ":" + timeM2.minutes + " до " + timeA1.hour + ":" + timeA1.minutes;
                }
                final.FreeTime(timeA2, timeE1);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeA2.hour + ":" + timeA2.minutes + " до " + timeE1.hour + ":" + timeE1.minutes;
                }
                final.FreeTime(timeE2, night);
                if (final.hour != 0)
                {
                    timeFinallization.textBox1.Text += "Встреча возможна с " + timeE2.hour + ":" + timeE2.minutes + " до " + night.hour + ":" + night.minutes;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
