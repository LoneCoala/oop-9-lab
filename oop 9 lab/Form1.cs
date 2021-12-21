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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitFromProgram()
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitFromProgram();
        }

        private void openAddRecord()
        {
            AddRecord addRecord = new AddRecord();
            addRecord.ShowDialog();
        }
        private void openChangeRecord()
        {
            ChangeRecord changeRecord = new ChangeRecord();
            changeRecord.id = realId;
            changeRecord.surname.Text = dataGridView1.Rows[whatDataCellClicked].Cells[1].Value.ToString();
            changeRecord.name.Text = dataGridView1.Rows[whatDataCellClicked].Cells[2].Value.ToString();
            changeRecord.fatherName.Text = dataGridView1.Rows[whatDataCellClicked].Cells[3].Value.ToString();
            changeRecord.phoneNumber.Text = dataGridView1.Rows[whatDataCellClicked].Cells[4].Value.ToString();
            changeRecord.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openAddRecord();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openChangeRecord();
        }

        private SqlConnection sqlConnection = null;
        public SqlCommandBuilder sqlBuilder = null;
        public SqlDataAdapter sqlDataAdapter = null;
        public DataSet dataSet = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            sqlConnection.Open();
            /*
            if (sqlConnection.State == ConnectionState.Open)
                MessageBox.Show("Подключение установлено");
            */
            initializationOfDB();
        }
        public int whatDataCellClicked = 0;
        public int realId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clickOnDataCell();
        }

        public void initializationOfDB()
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Phonebook", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet,"Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Синхронизировать
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            initializationOfDB();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Удаление
            if (MessageBox.Show("Удалить строку с " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Id"] + " " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Surname"] + " " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Name"] + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC [Delete] @Id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("Id", Convert.ToInt32(dataSet.Tables["Test"].Rows[whatDataCellClicked]["Id"]));
                sqlCommand.ExecuteNonQuery();
                initializationOfDB();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clickOnDataCell();
        }

        private void clickOnDataCell()
        {
            whatDataCellClicked = dataGridView1.CurrentCell.RowIndex;
            realId = Convert.ToInt32(dataGridView1.Rows[whatDataCellClicked].Cells[0].Value);
        }
    }
}
