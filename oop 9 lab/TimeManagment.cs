using System;
using System.Windows.Forms;

namespace oop_9_lab
{
    public partial class TimeManagment : Form
    {
        public TimeManagment()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox.CheckedItems.Count; i++)
            {
                string s = ListBox.CheckedItems[i].ToString();
                MessageBox.Show(s,s);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeManagment_Load(object sender, EventArgs e)
        {

        }
    }
}
