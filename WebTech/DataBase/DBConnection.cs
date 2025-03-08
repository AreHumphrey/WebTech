using System;
using System.Data.SqlClient;

namespace TechDep
{
    class DBConnection
    {
        static string connectionString = @"Data Source=HUMPHREY\SQLEXPRESS;Initial Catalog=TechDep;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }

        public void CreateDatabase()
        {
            string query = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'TechDep') " +
                           "BEGIN CREATE DATABASE TechDep END;";

            using (SqlConnection masterConnection = new SqlConnection(@"Data Source=HUMPHREY\SQLEXPRESS;Integrated Security=True"))
            {
                masterConnection.Open();
                SqlCommand command = new SqlCommand(query, masterConnection);
                command.ExecuteNonQuery();
            }
        }

        public void CreateTables()
        {
            string query = @"
            USE TechDep;

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Clients')
            BEGIN
                CREATE TABLE Clients (
                    Organization_ID INTEGER NOT NULL IDENTITY(1,1),
                    Organization_name VARCHAR(100) NOT NULL,
                    Organization_address VARCHAR(100) NOT NULL,
                    Client_full_name VARCHAR(100) NOT NULL,
                    Client_phone VARCHAR(30) NOT NULL UNIQUE,
                    PRIMARY KEY (Organization_ID)
                );
            END;

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees')
            BEGIN
                CREATE TABLE Employees (
                    Employee_ID INTEGER NOT NULL IDENTITY(1,1),
                    Employee_username VARCHAR(100) NOT NULL UNIQUE,
                    Employee_full_name VARCHAR(100) NOT NULL,
                    Employee_job_title VARCHAR(50) NOT NULL,
                    Employee_phone VARCHAR(100) NOT NULL UNIQUE,
                    Employee_pass_hash VARCHAR(200) NOT NULL,
                    IsAdmin BIT,
                    PRIMARY KEY (Employee_ID)
                );
            END;

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders')
            BEGIN
                CREATE TABLE Orders (
                    Order_ID INTEGER NOT NULL IDENTITY(1,1),
                    Start_date DATETIME NOT NULL,
                    End_date VARCHAR(50) NOT NULL,
                    Order_status VARCHAR(50) NULL,
                    Order_sum VARCHAR(100) NULL,
                    Employee_ID INTEGER NOT NULL,
                    Organization_ID INTEGER NOT NULL,
                    PRIMARY KEY (Order_ID),
                    FOREIGN KEY (Employee_ID) REFERENCES Employees(Employee_ID) ON UPDATE NO ACTION ON DELETE NO ACTION,
                    FOREIGN KEY (Organization_ID) REFERENCES Clients(Organization_ID) ON UPDATE NO ACTION ON DELETE NO ACTION
                );
            END;

            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
            BEGIN
                CREATE TABLE Products (
                    Product_ID INTEGER NOT NULL IDENTITY(1,1),
                    Product_name VARCHAR(200) NOT NULL,
                    Product_description VARCHAR(500) NOT NULL,
                    Product_cost DECIMAL(10,2) NOT NULL,
                    Product_reserved VARCHAR(100) NOT NULL,
                    PRIMARY KEY (Product_ID)
                );
            END;


            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products_in_orders')
            BEGIN
                CREATE TABLE Products_in_orders (
                    Order_ID INTEGER NOT NULL,
                    Product_ID INTEGER NOT NULL,
                    PRIMARY KEY (Order_ID, Product_ID),
                    FOREIGN KEY (Order_ID) REFERENCES Orders(Order_ID) ON UPDATE CASCADE ON DELETE CASCADE,
                    FOREIGN KEY (Product_ID) REFERENCES Products(Product_ID) ON UPDATE NO ACTION ON DELETE NO ACTION
                );
            END;";

            openConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            closeConnection();
        }
    }
}
