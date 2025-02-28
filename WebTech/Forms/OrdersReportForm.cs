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
    public partial class OrdersReportForm : Form
    {
        DBConnection dbconnection = new DBConnection();

        public OrdersReportForm()
        {
            InitializeComponent();
        }

        private void OrdersReportForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            dbconnection.openConnection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            string querystring1 = "SELECT Orders.Order_ID AS [Номер заказа], " +
                                  "Start_datee AS [Дата создания заказа], " +
                                  "End_date AS [Дата выдачи заказа], " +
                                  "Order_status AS [Статус заказа], " +
                                  "SUM(Product_cost) AS [Сумма заказа], " +
                                  "SUBSTRING(Order_sum, CHARINDEX(' ', Order_sum) + 1, CHARINDEX(' ', Order_sum)) AS [Валюта заказа], " +
                                  "Employees.Employee_full_name AS [ФИО менеджера], " +
                                  "Clients.Client_full_name AS [ФИО клиента] " +
                                  "FROM Orders " +
                                  "INNER JOIN Clients ON Clients.Organization_ID = Orders.Organization_ID " +
                                  "INNER JOIN Employees ON Employees.Employee_ID = Orders.Employee_ID " +
                                  "INNER JOIN Products_in_orders ON Products_in_orders.Order_ID = Orders.Order_ID " +
                                  "INNER JOIN Products ON Products.Product_ID = Products_in_orders.Product_ID " +
                                  "GROUP BY Orders.Order_ID, Start_datee, End_date, Order_status, " +
                                  "Employees.Employee_full_name, Clients.Client_full_name, Order_sum";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter1.Fill(table1);
            dataGridView1.DataSource = table1;
            dbconnection.closeConnection();
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            new ExportHelper().Export(dataGridView1);
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
        }
    }
}
