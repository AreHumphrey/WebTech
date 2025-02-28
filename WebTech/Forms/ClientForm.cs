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

namespace TechDep
{
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class ClientForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Organization_name", "Имя организации");
            dataGridView1.Columns.Add("Organization_address", "Адрес организации");
            dataGridView1.Columns.Add("Client_full_name", "ФИО клиента");
            dataGridView1.Columns.Add("Client_phone", "Телефон клиента");
            dataGridView1.Columns.Add("Organization_ID", "ID организации");
            this.dataGridView1.Columns["Organization_ID"].Visible = false;
        }

        private void ClearFields()
        {
            NameOtextbox.Text = "";
            AddressOtextbox.Text = "";
            ClientFIOtextbox.Text = "";
            Phonetextbox.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), RoWState.Modified);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT Organization_name, Organization_address, Client_full_name, Client_phone, Organization_ID FROM Clients";
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

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            this.ActiveControl = label1;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                NameOtextbox.Text = row.Cells[0].Value.ToString();
                AddressOtextbox.Text = row.Cells[1].Value.ToString();
                ClientFIOtextbox.Text = row.Cells[2].Value.ToString();
                Phonetextbox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT Organization_name, Organization_address, Client_full_name, Client_phone, Organization_ID " +
                                  $"FROM Clients WHERE CONCAT(Organization_name, Organization_address, Client_full_name, Client_phone, Organization_ID) LIKE '%{SearchTextBox.Text}%'";
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

        private void NewClientButton_Click(object sender, EventArgs e)
        {
            dbconnection.openConnection();

            string name = NameOtextbox.Text;
            string address = AddressOtextbox.Text;
            string fio = ClientFIOtextbox.Text;
            string phone = Phonetextbox.Text;

            string querystring1 = $"SELECT * FROM Clients WHERE Client_phone = '{phone}'";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter { SelectCommand = sqlCommand1 };
            DataTable table1 = new DataTable();
            sqlDataAdapter1.Fill(table1);

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(phone))
            {
                if (table1.Rows.Count == 0)
                {
                    var addQuery = $"INSERT INTO Clients (Organization_name, Organization_address, Client_full_name, Client_phone) VALUES ('{name}','{address}','{fio}','{phone}')";
                    var command = new SqlCommand(addQuery, dbconnection.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbconnection.closeConnection();
                    RefreshDataGrid(dataGridView1);
                    ClearFields();
                    dataGridView1.ClearSelection();
                }
                else
                {
                    MessageBox.Show("В базе уже есть пользователь с таким телефоном!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }

        private void ChangeClientButton_Click(object sender, EventArgs e)
        {
            ChangeClient();
        }

        private void ChangeClient()
        {
            if (selectedRow >= 0)
            {
                string name = NameOtextbox.Text;
                string address = AddressOtextbox.Text;
                string fio = ClientFIOtextbox.Text;
                string phone = Phonetextbox.Text;
                int clientId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[4].Value);

                string updateQuery = $"UPDATE Clients SET Organization_name = '{name}', Organization_address = '{address}', Client_full_name = '{fio}', Client_phone = '{phone}' WHERE Organization_ID = {clientId}";
                SqlCommand command = new SqlCommand(updateQuery, dbconnection.getConnection());

                dbconnection.openConnection();
                command.ExecuteNonQuery();
                dbconnection.closeConnection();

                MessageBox.Show("Данные клиента обновлены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGrid(dataGridView1);
            }
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            string phone = Phonetextbox.Text;

            var addQuery = $"DELETE FROM Clients WHERE Client_phone = '{phone}'";
            var command = new SqlCommand(addQuery, dbconnection.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbconnection.closeConnection();
            RefreshDataGrid(dataGridView1);
            dataGridView1.ClearSelection();
            ClearFields();
        }
    }
}
