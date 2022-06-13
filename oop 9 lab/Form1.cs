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
        public int whatDayOfWeek = 1;

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
            addRecord.whatDayOfWeek = whatDayOfWeek;
            addRecord.ShowDialog();
            addRecord.Dispose();
            initializationOfDB(); // изменить, хотя зачем
        }


        private void openChangeRecord()
        {
            ChangeRecord changeRecord = new ChangeRecord();
            changeRecord.whatDayOfWeek = whatDayOfWeek;
            changeRecord.id = realId;
            changeRecord.surname.Text = dataGridView1.Rows[whatDataCellClicked].Cells[1].Value.ToString();
            changeRecord.name.Text = dataGridView1.Rows[whatDataCellClicked].Cells[2].Value.ToString();
            changeRecord.timeN1.Text = dataGridView1.Rows[whatDataCellClicked].Cells[3].Value.ToString();
            changeRecord.timeM1.Text = dataGridView1.Rows[whatDataCellClicked].Cells[4].Value.ToString();
            changeRecord.timeM2.Text = dataGridView1.Rows[whatDataCellClicked].Cells[5].Value.ToString();
            changeRecord.timeA1.Text = dataGridView1.Rows[whatDataCellClicked].Cells[6].Value.ToString();
            changeRecord.timeA2.Text = dataGridView1.Rows[whatDataCellClicked].Cells[7].Value.ToString();
            changeRecord.timeE1.Text = dataGridView1.Rows[whatDataCellClicked].Cells[8].Value.ToString();
            changeRecord.timeE2.Text = dataGridView1.Rows[whatDataCellClicked].Cells[9].Value.ToString();
            changeRecord.timeN2.Text = dataGridView1.Rows[whatDataCellClicked].Cells[10].Value.ToString();
            changeRecord.ShowDialog();
            changeRecord.Dispose();
            initializationOfDB();
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



        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Синхронизировать
            while (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
            initializationOfDB();
            MessageBox.Show("Синхронизировано, показан понедельник", "Синхронизация успешна");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // Удаление
            if (MessageBox.Show("Удалить строку с " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Id"] + " " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Surname"] + " " + dataSet.Tables["Test"].Rows[whatDataCellClicked]["Name"] + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand sqlCommand;
                sqlCommand = new SqlCommand("EXEC [Delete] @Id", sqlConnection);
                if (whatDayOfWeek == 1)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteMon] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 2)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteTue] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 3)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteWed] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 4)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteThu] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 5)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteFri] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 6)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteSat] @Id", sqlConnection);
                }
                if (whatDayOfWeek == 7)
                {
                    sqlCommand.Dispose();
                    sqlCommand = new SqlCommand("EXEC [DeleteSun] @Id", sqlConnection);
                }

                sqlCommand.Parameters.AddWithValue("Id", Convert.ToInt32(dataSet.Tables["Test"].Rows[whatDataCellClicked]["Id"]));
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
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

        public void initializationOfDB()
        {
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Mon", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }


        private void понедельникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 1;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Mon", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void вторникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 2;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Tue", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void средаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 3;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Wed", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void четвергToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 4;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Thu", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void пятницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 5;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Fri", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void субботаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 6;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Sat", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void воскресеньеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whatDayOfWeek = 7;
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Sun", sqlConnection);
            dataSet.Tables.Clear();
            sqlDataAdapter.Fill(dataSet, "Test");
            dataGridView1.DataSource = dataSet.Tables["Test"];
            sqlDataAdapter.Dispose();
        }

        private void timeManagement_Click(object sender, EventArgs e)
        {
            TimeManagment timeManagment = new TimeManagment();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                timeManagment.ListBox.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[1].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[2].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[3].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[4].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[5].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[6].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[7].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[8].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[9].Value.ToString()
                                  + " " + dataGridView1.Rows[i].Cells[10].Value.ToString());
            }
            timeManagment.ShowDialog();
            timeManagment.Dispose();
            initializationOfDB();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}