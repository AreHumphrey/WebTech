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
    public partial class ProductsReportForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        public ProductsReportForm()
        {
            InitializeComponent();
        }
        private void ProductsReportForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;

            dbconnection.openConnection();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            DataTable table1 = new DataTable();
            string querystring1 = $"select Product_ID as [ID продукта]," +
                $"Product_name as [Название продукта], Product_description as [Описание продукта]," +
                $"Product_cost[Стоимость продукта], Product_reserved as [Статус продукта] from" +
                $"Products";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1,
           dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter1.Fill(table1);
            dataGridView1.DataSource = table1;
            dbconnection.closeConnection();
            dataGridView1.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("enUS");
            new ExportHelper().Export(dataGridView1);
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ruRU");
        }
    }
}
