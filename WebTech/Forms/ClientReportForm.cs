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
    public partial class ClientReportForm : Form
    {
        DBConnection dbconnection = new DBConnection();

        public ClientReportForm()
        {
            InitializeComponent();
        }

        private void ClientReportForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            dbconnection.openConnection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            string querystring1 = "SELECT Organization_name AS [Название организации], " +
                                  "Client_full_name AS [Полное имя клиента], " +
                                  "Client_phone AS [Телефон клиента], " +
                                  "Order_ID AS [Номер заказа], " +
                                  "Start_datee AS [Дата создания заказа], " +
                                  "End_date AS [Дата выдачи заказа], " +
                                  "Order_status AS [Статус заказа] " +
                                  "FROM Clients INNER JOIN Orders ON Orders.Organization_ID = Clients.Organization_ID";
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
