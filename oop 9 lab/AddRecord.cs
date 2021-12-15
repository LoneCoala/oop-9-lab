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
            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Подключение установлено");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(surname.Text)) || (String.IsNullOrWhiteSpace(name.Text)))
            {
                MessageBox.Show("Вы не ввели имя или фамилию!", "Внимание!");
                return;
            }
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO [Phonebook] (Surname,Name,FatherName,PhoneNumber) Values (@Surname,@Name,@FatherName,@PhoneNumber)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Surname", surname.Text);
            sqlCommand.Parameters.AddWithValue("Name", name.Text);
            sqlCommand.Parameters.AddWithValue("FatherName", fatherName.Text);
            sqlCommand.Parameters.AddWithValue("PhoneNumber", phoneNumber.Text);
            sqlCommand.ExecuteNonQuery();
            //MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());
            this.Close();
        }
    }
}
