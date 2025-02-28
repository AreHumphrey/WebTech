using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TechDep
{
    enum RoWState1
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class ProductsForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Product_name", "Название продукта");
            dataGridView1.Columns.Add("Product_description", "Описание продукта");
            dataGridView1.Columns.Add("Product_cost", "Цена продукта");
            dataGridView1.Columns.Add("Product_reserved", "Статус продукта");
            dataGridView1.Columns.Add("Product_ID", "ID продукта");
            this.dataGridView1.Columns["Product_ID"].Visible = false;
        }
        private void ClearFields()
        {
            NamePtextbox.Text = "";
            DescriptionPtextbox.Text = "";
            CostPtextbox.Text = "";
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDecimal(2), record.GetString(3), record.GetInt32(4));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "select Product_name, Product_description, Product_cost, Product_reserved, Product_ID from Products";
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
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            this.ActiveControl = label1;
            dataGridView1.ClearSelection();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                NamePtextbox.Text = row.Cells[0].Value.ToString();
                DescriptionPtextbox.Text = row.Cells[1].Value.ToString();
                CostPtextbox.Text = row.Cells[2].Value.ToString();
            }
        }
        private void ClearImg_Click_1(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }
        private void AnotherStick_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "select Product_name, Product_description, Product_cost, Product_reserved, Product_ID from Products where concat (Product_name, Product_description, Product_cost, Product_reserved, Product_ID) like @search";
            SqlCommand com = new SqlCommand(searchString, dbconnection.getConnection());
            com.Parameters.AddWithValue("@search", "%" + SearchTextBox.Text + "%");
            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
            dbconnection.closeConnection();
        }
        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void AddProduct()
        {
            dbconnection.openConnection();
            var name = NamePtextbox.Text;
            var description = DescriptionPtextbox.Text;
            decimal cost;
            var cost1 = CostPtextbox.Text;
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string pattern = "^[1-9]{1}\\d*[.]\\d{1,2}";  
            string pattern1 = "^[1-9]{1}\\d*";  

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(cost1))
            {
                if (decimal.TryParse(cost1, out cost))
                {
                    if (Regex.IsMatch(cost1, pattern, RegexOptions.IgnoreCase) || Regex.IsMatch(cost1, pattern1, RegexOptions.IgnoreCase))
                    {
                        try
                        {
                            string addQuery = "insert into Products (Product_name, Product_description, Product_cost, Product_reserved) values (@name, @description, @cost, 'Доступен')";
                            SqlCommand command = new SqlCommand(addQuery, dbconnection.getConnection());
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@description", description);
                            command.Parameters.AddWithValue("@cost", cost);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dbconnection.closeConnection();
                            RefreshDataGrid(dataGridView1);
                            ClearFields();
                            SearchTextBox.Text = "";
                            dataGridView1.ClearSelection();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Ошибка при добавлении записи!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Дробная часть цены не превышает два знака после запятой либо число должно быть целым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }
        private void NewProductButton_Click(object sender, EventArgs e)
        {
            AddProduct();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
        }
    }
}
