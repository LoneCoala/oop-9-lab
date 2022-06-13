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
    public partial class ChangeRecord : Form
    {
        public ChangeRecord()
        {
            InitializeComponent();
        }
        private SqlConnection sqlConnection = null;
        SqlDataReader sqlDataReader = null;
        Form1 form1 = new Form1();
        public SqlDataAdapter sqlDataAdapter = null;
        DataSet dataSet = new DataSet();

        public int id = 0;
        private void ChangeRecord_Load(object sender, EventArgs e)
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
            if ((String.IsNullOrWhiteSpace(surname.Text)) || (String.IsNullOrWhiteSpace(name.Text)))
            {
                MessageBox.Show("Вы не ввели имя или фамилию!", "Внимание!");
                return;
            }

            Form1 form1 = new Form1();
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("EXEC [UpdateMon] @Surname,@Name,@TimeN1,@TimeM1,@TimeM2,@TimeA1,@TimeA2,@TimeE1,@TimeE2,@TimeN2, @Id", sqlConnection);
            if ((String.IsNullOrWhiteSpace(surname.Text)) || (String.IsNullOrWhiteSpace(name.Text)))
            {
                MessageBox.Show("Вы не ввели имя или фамилию!", "Внимание!");
                return;
            }
            if (whatDayOfWeek == 1)
            {
                MessageBox.Show("Изменения приняты","Понедельник") ;
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateMon]  @Surname,@Name,@TimeN1,@TimeM1,@TimeM2,@TimeA1,@TimeA2,@TimeE1,@TimeE2,@TimeN2, @Id", sqlConnection);
            }
            if (whatDayOfWeek == 2)
            {
                MessageBox.Show("2", "1");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateTue] @Surname,@Name,@TimeN1,@TimeM1,@TimeM2,@TimeA1,@TimeA2,@TimeE1,@TimeE2,@TimeN2, @Id", sqlConnection);
            }
            if (whatDayOfWeek == 3)
            {
                MessageBox.Show("3", "3");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateWed] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2,@Id", sqlConnection);
            }
            if (whatDayOfWeek == 4)
            {
                MessageBox.Show("4", "4");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateThu] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2,@Id", sqlConnection);
            }
            if (whatDayOfWeek == 5)
            {
                MessageBox.Show("5", "5");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateFri] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2,@Id", sqlConnection);
            }
            if (whatDayOfWeek == 6)
            {
                MessageBox.Show("6", "6");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateSat] @Surname,@Name,@TimeN1,@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2,@Id", sqlConnection);
            }
            if (whatDayOfWeek == 7)
            {
                MessageBox.Show("7","7");
                sqlCommand.Dispose();
                sqlCommand = new SqlCommand("EXEC [UpdateSun] @Surname,@Name,@TimeN1,@TimeM1,@TimeM2,@TimeA1,@TimeA2,@TimeE1,@TimeE2,@TimeN2, @Id", sqlConnection);
            }


            //SqlCommand sqlCommand = new SqlCommand("EXEC [Insert] @Surname,@Name,@TimeN1@TimeN2,@TimeA1,@TimeA2,@TimeM1,@TimeM2,@TimeE1,@TimeE2", sqlConnection);
            //SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Phonebook] (Surname,Name,FatherName,PhoneNumber) Values (@Surname,@Name,@FatherName,@PhoneNumber)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Id", id);
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
