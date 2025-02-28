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
    public partial class EmployeeReportForm : Form
    {
        DBConnection dbconnection = new DBConnection();

        public EmployeeReportForm()
        {
            InitializeComponent();
        }

        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label2;
            dbconnection.openConnection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter
            {
                MissingSchemaAction = MissingSchemaAction.AddWithKey
            };

            DataTable table1 = new DataTable();
            string querystring1 = "SELECT Employees.Employee_ID, " +
                                  "Employee_full_name AS [Полное имя сотрудника], " +
                                  "Employee_job_title AS [Должность сотрудника], " +
                                  "COUNT(Orders.Order_ID) AS [Количество сделок] " +
                                  "FROM Orders INNER JOIN Employees ON Employees.Employee_ID = Orders.Employee_ID " +
                                  "GROUP BY Employee_full_name, Employee_job_title, Employees.Employee_ID";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter1.Fill(table1);

            DataTable table = new DataTable();
            string qa = "SELECT Employees.Employee_ID, " +
                        "Employee_full_name AS [Полное имя сотрудника], " +
                        "Employee_job_title AS [Должность сотрудника], " +
                        "SUM(Product_cost) AS [Выручка] " +
                        "FROM Employees " +
                        "INNER JOIN Orders ON Employees.Employee_ID = Orders.Employee_ID " +
                        "INNER JOIN Products_in_orders ON Products_in_orders.Order_ID = Orders.Order_ID " +
                        "INNER JOIN Products ON Products.Product_ID = Products_in_orders.Product_ID " +
                        "WHERE Order_status = 'Выполнен' " +
                        "GROUP BY Employee_full_name, Employee_job_title, Employees.Employee_ID;";
            SqlCommand sqlCommand = new SqlCommand(qa, dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand;
            sqlDataAdapter1.Fill(table);

            table1.Merge(table, false, MissingSchemaAction.AddWithKey);
            dataGridView2.DataSource = table1;
            dbconnection.closeConnection();
            dataGridView2.ClearSelection();
            dataGridView2.Columns["Employee_ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            new ExportHelper().Export(dataGridView2);
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
        }
    }
}
