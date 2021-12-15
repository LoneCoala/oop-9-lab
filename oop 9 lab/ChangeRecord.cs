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
            SqlCommand sqlCommand = new SqlCommand("UPDATE Phonebook SET Surname = @Surname, Name = @Name, FatherName = @FatherName, PhoneNumber = @PhoneNumber WHERE Id = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("Surname", surname.Text);
            sqlCommand.Parameters.AddWithValue("Name", name.Text);
            sqlCommand.Parameters.AddWithValue("FatherName", fatherName.Text);
            sqlCommand.Parameters.AddWithValue("PhoneNumber", phoneNumber.Text);
            sqlCommand.Parameters.AddWithValue("Id", id);
            sqlCommand.ExecuteNonQuery();
            //MessageBox.Show(sqlCommand.ExecuteNonQuery().ToString());
            this.Close();
        }
    }
}
