using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace oop_9_lab
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }
        private SqlConnection sqlConnection = null;

        private void AddRecord_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            sqlConnection.Open();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int whatDayOfWeek = 1;
        private void addButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("EXEC [InsertMon] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            if ((String.IsNullOrWhiteSpace(surname.Text)) || (String.IsNullOrWhiteSpace(name.Text)))
            {
                MessageBox.Show("Вы не ввели имя или фамилию!", "Внимание!");
                return;
            }

            if (whatDayOfWeek == 1)
            {
                sqlCommand = new SqlCommand("EXEC [InsertMon] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 2)
            {
                sqlCommand = new SqlCommand("EXEC [InsertTue] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 3)
            {
                sqlCommand = new SqlCommand("EXEC [InsertWed] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 4)
            {
                sqlCommand = new SqlCommand("EXEC [InsertThu] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 5)
            {
                sqlCommand = new SqlCommand("EXEC [InsertFri] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 6)
            {
                sqlCommand = new SqlCommand("EXEC [InsertSat] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }
            if (whatDayOfWeek == 7)
            {
                sqlCommand = new SqlCommand("EXEC [InsertSun] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            }


            //SqlCommand sqlCommand = new SqlCommand("EXEC [Insert] @Surname,@Name,@TimeN1@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            //SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Phonebook] (Surname,Name,FatherName,PhoneNumber) Values (@Surname,@Name,@FatherName,@PhoneNumber)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("Surname", surname.Text);
            sqlCommand.Parameters.AddWithValue("Name", name.Text);
            sqlCommand.Parameters.AddWithValue("TimeN1", timeN1.Text);
            sqlCommand.Parameters.AddWithValue("TimeN2", timeN2.Text);
            sqlCommand.Parameters.AddWithValue("TimeA1", timeA1.Text);
            sqlCommand.Parameters.AddWithValue("TimeA2", timeA2.Text);
            sqlCommand.Parameters.AddWithValue("TimeE1", timeE1.Text);
            sqlCommand.Parameters.AddWithValue("TimeE2", timeE2.Text);
            sqlCommand.Parameters.AddWithValue("TimeM1", timeM1.Text);
            sqlCommand.Parameters.AddWithValue("TimeM2", timeM2.Text);

            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            sqlConnection.Close();
            sqlConnection.Dispose();
            //MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());
            this.Close();
        }
    }
}
