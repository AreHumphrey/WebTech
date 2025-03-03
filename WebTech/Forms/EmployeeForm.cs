using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TechDep
{
    enum RoWState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class EmployeeForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Employee_full_name", "ФИО сотрудника");
            dataGridView1.Columns.Add("Employee_job_title", "Должность сотрудника");
            dataGridView1.Columns.Add("Employee_phone", "Телефон сотрудника");
            dataGridView1.Columns.Add("Employee_username", "Логин сотрудника");
            dataGridView1.Columns.Add("Employee_pass_hash", "Пароль сотрудника");
            dataGridView1.Columns.Add("Employee_ID", "ID сотрудника");
            dataGridView1.Columns.Add("IsAdmin", "Статус админа");

            this.dataGridView1.Columns["Employee_ID"].Visible = false;
            this.dataGridView1.Columns["IsAdmin"].Visible = false;
        }

        private void ClearFields()
        {
            Logintextbox.Text = "";
            Passwordtextbox.Text = "";
            Efiotextbox.Text = "";
            EjobtitletextBox.Text = "";
            Ephonetextbox.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2),
                         record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetBoolean(6), RoWState2.Modified);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT Employee_full_name, Employee_job_title, Employee_phone, " +
                                 "Employee_username, Employee_pass_hash, Employee_ID, IsAdmin FROM Employees";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
            dbconnection.closeConnection();
        }

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            dataGridView1.ClearSelection();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                Efiotextbox.Text = row.Cells[0].Value.ToString();
                EjobtitletextBox.Text = row.Cells[1].Value.ToString();
                Ephonetextbox.Text = row.Cells[2].Value.ToString();
                Logintextbox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "SELECT Employee_full_name, Employee_job_title, Employee_phone, " +
                                  "Employee_username, Employee_pass_hash, Employee_ID, IsAdmin " +
                                  "FROM Employees WHERE CONCAT(Employee_full_name, Employee_job_title, " +
                                  "Employee_phone, Employee_username, Employee_pass_hash, Employee_ID, IsAdmin) " +
                                  $"LIKE '%{SearchTextBox.Text}%'";
            SqlCommand com = new SqlCommand(searchString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
            dbconnection.closeConnection();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void AddEmployee()
        {
            dbconnection.openConnection();
            var login = Logintextbox.Text;
            var password = MD5.HashPassword(Passwordtextbox.Text);
            var fio = Efiotextbox.Text;
            var jobt = EjobtitletextBox.Text;
            var phone = Ephonetextbox.Text;
            var status = checkBox1.Checked;

            string querystring1 = $"SELECT * FROM Employees WHERE Employee_phone = '{phone}'";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter { SelectCommand = sqlCommand1 };
            DataTable table1 = new DataTable();
            sqlDataAdapter1.Fill(table1);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(jobt) && !string.IsNullOrEmpty(phone))
            {
                if (table1.Rows.Count == 0)
                {
                    var addQuery = $"INSERT INTO Employees (Employee_username, Employee_full_name, Employee_job_title, Employee_phone, Employee_pass_hash, IsAdmin) " +
                                   $"VALUES ('{login}','{fio}','{jobt}','{phone}','{password}', {(status ? 1 : 0)})";
                    SqlCommand command = new SqlCommand(addQuery, dbconnection.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbconnection.closeConnection();
                    RefreshDataGrid(dataGridView1);
                    ClearFields();
                    SearchTextBox.Text = "";
                    checkBox1.Checked = false;
                }
                else
                {
                    MessageBox.Show("В базе уже есть сотрудник с таким телефоном!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                }
            }
        }

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
