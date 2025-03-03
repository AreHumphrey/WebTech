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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechDep
{
    enum RoWState4
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainForm : Form
    {
        private readonly CheckUser _user;
        DBConnection dbconnection = new DBConnection();
        int selectedRow;

        private void CreateColumnsClients()
        {
            dataGridView2.Columns.Add("Client_full_name", "ФИО клиента");
            dataGridView2.Columns.Add("Client_phone", "Телефон клиента");
            dataGridView2.Columns.Add("Organization_ID", "ID организации");
            this.dataGridView2.Columns["Organization_ID"].Visible = false;
        }

        private void CreateColumnsOrders()
        {
            dataGridView1.Columns.Add("Client_full_name", "ФИО заказчика");
            dataGridView1.Columns.Add("Employee_full_name", "ФИО принимающего");
            dataGridView1.Columns.Add("Start_datee", "Дата принятия заказа");
            dataGridView1.Columns.Add("End_date", "Дата выдачи заказа");
            dataGridView1.Columns.Add("Order_status", "Статус заказа");
            dataGridView1.Columns.Add("Order_sum", "Сумма заказа");
            dataGridView1.Columns.Add("Order_ID", "ID заказа");

            this.dataGridView1.Columns["Order_ID"].Visible = false;
            this.dataGridView1.Columns["Order_sum"].Visible = false;
        }

        private void CreateColumnsProducts()
        {
            dataGridView3.Columns.Add("Product_name", "Название продукта");
            dataGridView3.Columns.Add("Product_description", "Описание продукта");
            dataGridView3.Columns.Add("Product_cost", "Цена продукта");
            dataGridView3.Columns.Add("Product_reserved", "Статус продукта");
            dataGridView3.Columns.Add("Product_ID", "ID продукта");

            this.dataGridView3.Columns["Product_ID"].Visible = false;
        }

        private void ClearFieldClientSearch()
        {
            SearchClienttextbox.Text = "";
        }

        private void ClearFieldOrderSearch()
        {
            SearchOrderTextBox.Text = "";
        }

        private void ClearFieldProductSearch()
        {
            SearchProducttextbox.Text = "";
        }

        private void ReadSingleRowClient(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), RoWState4.Modified);
        }

        private void ReadSingleRowOrders(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDateTime(2),
                         record.GetString(3), record.GetString(4), record.GetString(5),
                         record.GetInt32(6), RoWState4.Modified);
        }

        private void ReadSingleRowProducts(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetDecimal(2),
                         record.GetString(3), record.GetInt32(4), RoWState4.Modified);
        }

        private void RefreshDataGridClients(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT Client_full_name, Client_phone, Organization_ID FROM Clients";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowClient(dgw, reader);
            }

            reader.Close();
            dbconnection.closeConnection();
        }

        private void RefreshDataGridOrders(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = @"SELECT Client_full_name, Employee_full_name, Start_datee, 
                                          End_date, Order_status, Order_sum, Order_ID 
                                   FROM Orders 
                                   INNER JOIN Employees ON Employees.Employee_ID = Orders.Employee_ID 
                                   INNER JOIN Clients ON Clients.Organization_ID = Orders.Organization_ID";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowOrders(dgw, reader);
            }

            reader.Close();
            dbconnection.closeConnection();
        }

        private void RefreshDataGridProducts(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT Product_name, Product_description, Product_cost, Product_reserved, Product_ID FROM Products";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowProducts(dgw, reader);
            }

            reader.Close();
            dbconnection.closeConnection();
        }

        // Закомментированный метод, если понадобится в будущем
        /*
        private void RefreshDataGridProductsInOrders(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = "SELECT Product_name, Product_description, Product_cost, Product_ID FROM Products";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowProductsInOrders(dgw, reader);
            }
            reader.Close();
            dbconnection.closeConnection();
        }
        */

        public MainForm(CheckUser user)
        {
            _user = user;
            InitializeComponent();
        }

        private void isAdmin()
        {
            добавлениеСотрудникаToolStripMenuItem.Enabled = _user.IsAdmin;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"{_user.Login}: {_user.Status}";
            label6.Text = $"{_user.Employee_ID}";
            isAdmin();

            this.ActiveControl = label2;
            CreateColumnsClients();
            CreateColumnsOrders();
            CreateColumnsProducts();

            RefreshDataGridOrders(dataGridView1);
            RefreshDataGridClients(dataGridView2);
            RefreshDataGridProducts(dataGridView3);

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();

            label5.Visible = false; // client id
            label6.Visible = false; // emp id
            label7.Visible = false; // order id
            label11.Visible = false; // product id
            dataGridView4.Visible = false;
            productsinOlabel.Visible = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
                label5.Text = row.Cells[2].Value.ToString();
            }
        }

        private void OPA()
        {
            dbconnection.openConnection();
            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[6, selectedRowIDX].Value);

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            string addQuery = "SELECT Product_name AS [Название продукта], Product_description AS [Описание продукта], " +
                              "Product_cost AS [Цена продукта], Products.Product_ID AS [ID продукта] " +
                              "FROM Products INNER JOIN Products_in_orders ON Products.Product_ID = Products_in_orders.Product_ID " +
                              "INNER JOIN Orders ON Products_in_orders.Order_ID = Orders.Order_ID WHERE Orders.Order_ID = @aza";

            SqlCommand command = new SqlCommand(addQuery, dbconnection.getConnection());
            command.Parameters.AddWithValue("@aza", aza);

            DataTable table = new DataTable();
            sqlDataAdapter1.SelectCommand = command;
            sqlDataAdapter1.Fill(table);
            dataGridView4.DataSource = table;
            this.dataGridView4.Columns["ID продукта"].Visible = false;
            this.dataGridView4.ClearSelection();

            DataTable table1 = new DataTable();
            string sumQuery = "SELECT SUM(Product_cost) AS сумма FROM Products " +
                              "INNER JOIN Products_in_orders ON Products.Product_ID = Products_in_orders.Product_ID " +
                              "INNER JOIN Orders ON Products_in_orders.Order_ID = Orders.Order_ID WHERE Orders.Order_ID = @aza";

            SqlCommand sumCommand = new SqlCommand(sumQuery, dbconnection.getConnection());
            sumCommand.Parameters.AddWithValue("@aza", aza);

            sqlDataAdapter1.SelectCommand = sumCommand;
            sqlDataAdapter1.Fill(table1);
            decimal result;
            dbconnection.closeConnection();

            try
            {
                if (decimal.TryParse(Convert.ToString(table1.Rows[0].Field<decimal>("сумма")), out result))
                {
                    sumOrderLabel.Text = Convert.ToString(table1.Rows[0].Field<decimal>("сумма")) + " RUR";
                    dataGridView4.Visible = true;
                }
            }
            catch (Exception)
            {
                sumOrderLabel.Text = "0 RUR";
                dataGridView4.Visible = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                label7.Text = row.Cells[6].Value.ToString();
            }
            OPA();
            dataGridView4.ClearSelection();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];
                label11.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];
                productsinOlabel.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ClearOrderSearch_Click(object sender, EventArgs e)
        {
            ClearFieldOrderSearch();
        }

        private void ClearClientSearch_Click(object sender, EventArgs e)
        {
            ClearFieldClientSearch();
        }

        private void ClearProductSearch_Click(object sender, EventArgs e)
        {
            ClearFieldProductSearch();
        }

        private void SearchClient(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "SELECT Client_full_name, Client_phone, Organization_ID FROM Clients " +
                                  "WHERE CONCAT(Client_full_name, Client_phone) LIKE @search";
            SqlCommand com = new SqlCommand(searchString, dbconnection.getConnection());
            com.Parameters.AddWithValue("@search", "%" + SearchClienttextbox.Text + "%");

            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRowClient(dgw, read);
            }
            read.Close();
            dbconnection.closeConnection();
        }


        private void SearchOrder(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT Client_full_name, Employee_full_name, Start_datee, End_date, Order_status, Order_sum, Order_ID " +
                                  $"FROM Orders INNER JOIN Employees ON Employees.Employee_ID = Orders.Employee_ID " +
                                  $"INNER JOIN Clients ON Clients.Organization_ID = Orders.Organization_ID " +
                                  $"WHERE CONCAT(Client_full_name, Client_phone) LIKE '%{SearchOrderTextBox.Text}%'";

            SqlCommand com = new SqlCommand(searchString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowOrders(dgw, read);
            }

            read.Close();
            dbconnection.closeConnection();
        }

        private void SearchProduct(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT Product_name, Product_description, Product_cost, Product_reserved, Product_ID " +
                                  $"FROM Products WHERE CONCAT(Product_name, Product_description, Product_cost, Product_reserved) " +
                                  $"LIKE '%{SearchProducttextbox.Text}%'";

            SqlCommand com = new SqlCommand(searchString, dbconnection.getConnection());

            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRowProducts(dgw, read);
            }

            read.Close();
            dbconnection.closeConnection();
        }

        private void SearchClienttextbox_TextChanged(object sender, EventArgs e)
        {
            SearchClient(dataGridView2);
        }

        private void SearchOrderTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchOrder(dataGridView1);
        }

        private void SearchProducttextbox_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(dataGridView3);
        }

        private void linkLabelChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthenticateForm authenticateForm = new AuthenticateForm();
            authenticateForm.ShowDialog();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void updateClientspicbox_Click(object sender, EventArgs e)
        {
            RefreshDataGridClients(dataGridView2);
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.Visible = false;
            sumOrderLabel.Text = "";
            productionLabel.Text = "";
        }

        private void updateOrderspicbox_Click(object sender, EventArgs e)
        {
            RefreshDataGridOrders(dataGridView1);
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.Visible = false;
            sumOrderLabel.Text = "";
            productionLabel.Text = "";
        }

        private void updateProductspic_Click(object sender, EventArgs e)
        {
            RefreshDataGridProducts(dataGridView3);
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.Visible = false;
            sumOrderLabel.Text = "";
            productionLabel.Text = "";
        }

        private void AddNewOrder()
        {
            dbconnection.openConnection();

            var empid = label6.Text;
            var clientid = label5.Text;
            DateTime dateTime = DateTime.Now;

            if (!string.IsNullOrEmpty(clientid))
            {
                var addQuery = $"INSERT INTO Orders (Start_datee, End_date, Order_status, Order_sum, Employee_ID, Organization_ID) " +
                               $"VALUES ('{dateTime}', 'Пусто', 'В работе', '0 RUB', '{empid}', '{clientid}')";

                SqlCommand command = new SqlCommand(addQuery, dbconnection.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbconnection.closeConnection();
                RefreshDataGridOrders(dataGridView1);
                ClearFieldOrderSearch();
                SearchClienttextbox.Text = "";
                SearchOrderTextBox.Text = "";
                label5.Text = "";
                label7.Text = "";

                dataGridView1.ClearSelection();
                dataGridView2.ClearSelection();
                dataGridView3.ClearSelection();
                dataGridView4.Visible = false;
                sumOrderLabel.Text = "";
            }
            else
            {
                MessageBox.Show("Выберите клиента, чтобы создать заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            AddNewOrder();
        }

        private void DeleteOrder()
        {
            dbconnection.openConnection();

            try
            {
                var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
                var orderid = Convert.ToInt32(dataGridView1[6, selectedRowIDX].Value);

                var status = label7.Text;
                var addQuery = $"DELETE FROM Orders WHERE Order_ID = '{orderid}'";

                if (status != "В работе")
                {
                    var upQuery = $"UPDATE Products SET Product_reserved = 'Доступен' FROM Products " +
                                  $"INNER JOIN Products_in_orders ON Products.Product_ID = Products_in_orders.Product_ID " +
                                  $"INNER JOIN Orders ON Orders.Order_ID = Products_in_orders.Order_ID " +
                                  $"WHERE Orders.Order_ID = '{orderid}'";

                    SqlCommand command = new SqlCommand(addQuery, dbconnection.getConnection());
                    command.ExecuteNonQuery();

                    SqlCommand upCommand = new SqlCommand(upQuery, dbconnection.getConnection());
                    upCommand.ExecuteNonQuery();

                    MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbconnection.closeConnection();
                    RefreshDataGridOrders(dataGridView1);
                    RefreshDataGridProducts(dataGridView3);
                    ClearFieldOrderSearch();
                    ClearFieldClientSearch();
                    SearchClienttextbox.Text = "";
                    SearchOrderTextBox.Text = "";
                    label5.Text = "";
                    label7.Text = "";

                    dataGridView1.ClearSelection();
                    dataGridView2.ClearSelection();
                    dataGridView3.ClearSelection();
                    dataGridView4.Visible = false;
                    sumOrderLabel.Text = "";
                }
                else
                {
                    MessageBox.Show("Нельзя удалять уже выполненные заказы!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                    dataGridView1.ClearSelection();
                    dataGridView2.ClearSelection();
                    dataGridView3.ClearSelection();
                }
            }



            catch (Exception)
            {
                MessageBox.Show("В базе данных нет заказов для удаления", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
             
           
        }
          

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        private void UpdateOrderInfo()
        {
            dbconnection.openConnection();
            try
            {
                var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
                var aza = Convert.ToInt32(dataGridView1[6, selectedRowIDX].Value);
                var orderid = label7.Text;
                var dateTime = DateTime.Now;
                var statusO = "Выполнен";
                var aza1 = Convert.ToString(dataGridView1[4, selectedRowIDX].Value);

                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                DataTable table1 = new DataTable();

                string querystring1 = $@"
                        SELECT * 
                        FROM Orders 
                        INNER JOIN Products_in_orders ON Orders.Order_ID = Products_in_orders.Order_ID 
                        INNER JOIN Products ON Products.Product_ID = Products_in_orders.Product_ID 
                        WHERE Orders.Order_ID = '{aza}'";

                SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
                sqlDataAdapter1.SelectCommand = sqlCommand1;
                sqlDataAdapter1.Fill(table1);

                var summao = sumOrderLabel.Text;

                if (!string.IsNullOrEmpty(orderid))
                {
                    if (aza1 != statusO)
                    {
                        if (table1.Rows.Count != 0)
                        {
                            var addQuery = $@"
                            UPDATE Orders 
                            SET End_date = '{dateTime}', Order_status = 'Выполнен', Order_sum = '{summao}' 
                            WHERE Order_ID = '{aza}'";

                            var command = new SqlCommand(addQuery, dbconnection.getConnection());

                            var upPQuery = $@"
                            UPDATE Products 
                            SET Product_reserved = 'Куплен' 
                            FROM Products 
                            INNER JOIN Products_in_orders ON Products.Product_ID = Products_in_orders.Product_ID 
                            INNER JOIN Orders ON Orders.Order_ID = Products_in_orders.Order_ID 
                            WHERE Orders.Order_ID = {aza}";

                            var command1 = new SqlCommand(upPQuery, dbconnection.getConnection());

                            command.ExecuteNonQuery();
                            command1.ExecuteNonQuery();

                            MessageBox.Show("Заказ успешно завершен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dbconnection.closeConnection();
                            RefreshDataGridOrders(dataGridView1);
                            ClearFieldOrderSearch();
                            ClearFieldClientSearch();
                            SearchClienttextbox.Text = "";
                            SearchOrderTextBox.Text = "";
                            label5.Text = "";
                            label7.Text = "";

                            dataGridView1.ClearSelection();
                            dataGridView2.ClearSelection();
                            dataGridView3.ClearSelection();
                            dataGridView4.ClearSelection();
                            dataGridView4.Visible = false;
                            sumOrderLabel.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Нельзя завершать заказ, который не содержит товаров!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dbconnection.closeConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Нельзя завершать уже выполненные заказы!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dbconnection.closeConnection();
                        dataGridView1.ClearSelection();
                        dataGridView2.ClearSelection();
                        dataGridView3.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Чтобы завершить заказ, его сперва нужно выбрать!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("В базе данных нет заказов для завершения", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }

        private void EndOrderButton_Click(object sender, EventArgs e)
        {
            UpdateOrderInfo();
        }

        private void addpInObutton_Click(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            // try
            // {

            var selectedRowIDX = dataGridView3.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView3[4, selectedRowIDX].Value);
            var aza1 = Convert.ToString(aza);
            var selectedRowIDX1 = dataGridView1.CurrentCell.RowIndex;
            var aza2 = Convert.ToString(dataGridView1[4, selectedRowIDX1].Value);
            var aza3 = "Выполнен";
            var orderid = label7.Text;
            var productid = label11.Text;

            if (!string.IsNullOrEmpty(orderid))
            {
                if (!string.IsNullOrEmpty(productid))
                {
                    if (aza2 != aza3)
                    {
                        var addQuery = $@"
                            INSERT INTO Products_in_orders (Order_ID, Product_ID) 
                            VALUES ('{orderid}', '{aza}')";

                        var command = new SqlCommand(addQuery, dbconnection.getConnection());

                        var upPquery = $@"
                            UPDATE Products 
                            SET Product_reserved = 'Забронирован' 
                            WHERE Product_ID = '{aza}'";

                        var command1 = new SqlCommand(upPquery, dbconnection.getConnection());

                        command.ExecuteNonQuery();
                        command1.ExecuteNonQuery();

                        MessageBox.Show("Продукт успешно добавлен в заказ!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbconnection.closeConnection();

                        // RefreshDataGridOrders(dataGridView1);
                        RefreshDataGridProducts(dataGridView3);
                        // ClearFieldOrderSearch();
                        ClearFieldProductSearch();
                        // label7.Text = "";
                        label11.Text = "";
                        // dataGridView1.ClearSelection();
                        dataGridView2.ClearSelection();
                        dataGridView3.ClearSelection();
                        dataGridView4.ClearSelection();

                        OPA();

                        dbconnection.openConnection();
                        var summao = sumOrderLabel.Text;

                        var settim = $@"
                            UPDATE Orders 
                            SET Order_sum = '{summao}' 
                            WHERE Order_ID = '{orderid}'";

                        var cmd = new SqlCommand(settim, dbconnection.getConnection());
                        cmd.ExecuteNonQuery();
                        dbconnection.closeConnection();

                        // dataGridView4.Visible = false;
                        // sumOrderLabel.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("В выполненные заказы нельзя добавлять товары!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dbconnection.closeConnection();
                        dataGridView1.ClearSelection();
                        dataGridView3.ClearSelection();
                        label11.Text = "";
                        label7.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Чтобы добавить товар в заказ, во вторую очередь нужно выбрать товар!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Чтобы добавить товар в заказ, в первую очередь нужно выбрать заказ!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
            // }
            // catch (Exception)
            // {
            //     MessageBox.Show("В базе данных нет товаров для добавления в заказ", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     dbconnection.closeConnection();
            // }
        }

        private void deleteFromOrder()
        {
            dbconnection.openConnection();
            try
            {
                var orderid = label7.Text;
                var productid = productsinOlabel.Text;
                var selectedRowIDX = dataGridView4.CurrentCell.RowIndex;
                var azaa = Convert.ToInt32(dataGridView4[3, selectedRowIDX].Value);
                var aza1 = Convert.ToString(azaa);
                var selectedRowIDX1 = dataGridView1.CurrentCell.RowIndex;
                var aza2 = Convert.ToString(dataGridView1[4, selectedRowIDX1].Value);
                var aza3 = "Выполнен";

                if (!string.IsNullOrEmpty(orderid))
                {
                    if (!string.IsNullOrEmpty(productid))
                    {
                        if (aza2 != aza3)
                        {
                            var addQuery = $@"
                    DELETE FROM Products_in_orders 
                    WHERE Order_ID = '{orderid}' AND Product_ID = '{azaa}'";
                            var command = new SqlCommand(addQuery, dbconnection.getConnection());

                            var upPquery = $@"
                    UPDATE Products 
                    SET Product_reserved = 'Доступен' 
                    WHERE Product_ID = '{azaa}'";
                            var command1 = new SqlCommand(upPquery, dbconnection.getConnection());

                            command1.ExecuteNonQuery();
                            command.ExecuteNonQuery();

                            MessageBox.Show("Продукт успешно удален из заказа!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dbconnection.closeConnection();

                            RefreshDataGridProducts(dataGridView3);
                            dataGridView2.ClearSelection();
                            dataGridView3.ClearSelection();
                            dataGridView4.ClearSelection();
                            OPA();
                            productsinOlabel.Text = "";

                            dbconnection.openConnection();
                            var summao = sumOrderLabel.Text;

                            var settim = $@"UPDATE Orders  SET Order_sum = '{summao}'  WHERE Order_ID = '{orderid}'";
                            var cmd = new SqlCommand(settim, dbconnection.getConnection());
                            cmd.ExecuteNonQuery();

                            dbconnection.closeConnection();
                        }
                        else
                        {
                            MessageBox.Show("Из выполненных заказов нельзя удалять товары!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dbconnection.closeConnection();
                            dataGridView1.ClearSelection();
                            dataGridView3.ClearSelection();
                            dataGridView4.ClearSelection();
                            label7.Text = "";
                            dataGridView4.Visible = false;
                            sumOrderLabel.Text = "";
                            productsinOlabel.Text = "";
                            this.ActiveControl = label2;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Чтобы удалить товар из заказа в первую очередь нужно выбрать заказ!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dbconnection.closeConnection();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("В заказе нету товаров для удаления!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }
        private void deletepFromOButton_Click(object sender, EventArgs e)
        {
            deleteFromOrder();
        }

        private void анализПродажСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReportForm empForm = new EmployeeReportForm();
            empForm.ShowDialog();
        }

        private void анализПокупокКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientReportForm clientFrom = new ClientReportForm();
            clientFrom.ShowDialog();
        }

        private void товарнаяСтатистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsReportForm pForm = new ProductsReportForm();
            pForm.ShowDialog();
        }

        private void статистикаЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersReportForm oForm = new OrdersReportForm();
            oForm.ShowDialog();
        }
    }
}


