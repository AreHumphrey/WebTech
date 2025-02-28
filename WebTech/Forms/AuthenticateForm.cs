using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TechDep
{
    public partial class AuthenticateForm1 : Form
    {
        DBConnection dbconnection = new DBConnection();

        public AuthenticateForm1()
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = true;
        }

        private void AuthenticateForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Loginn = LoginBox.Text.Trim();
            string Passw = MD5.HashPassword(PasswordBox.Text.Trim());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();

            // Проверка пользователя в БД по логину и паролю
            DataTable table1 = new DataTable();
            string querystring1 = $"SELECT [Employee_username], [Employee_pass_hash], IsAdmin, Employee_ID " +
                                  $"FROM [Employees] " +
                                  $"WHERE [Employee_username] = '{Loginn}' AND [Employee_pass_hash] = '{Passw}'";

            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter1.Fill(table1);

            if (!string.IsNullOrEmpty(Loginn) || !string.IsNullOrEmpty(Passw))
            {
                if (!string.IsNullOrEmpty(Loginn))
                {
                    if (!string.IsNullOrEmpty(Passw))
                    {
                        if (table1.Rows.Count == 1)
                        {
                            var user = new CheckUser(
                                table1.Rows[0].ItemArray[0].ToString(),
                                Convert.ToBoolean(table1.Rows[0].ItemArray[2]),
                                Convert.ToInt32(table1.Rows[0].ItemArray[3].ToString()));

                            this.Hide();
                            MainForm mainForm = new MainForm(user);
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Пользователя с такими данными не существует! Проверьте правильность логина или пароля, которые выдал вам администратор.",
                                "Некорректный ввод данных",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                            PasswordBox.BackColor = Color.Yellow;
                            LoginBox.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле ввода пароля пустое!", "Ошибка");
                        PasswordBox.BackColor = Color.RosyBrown;
                        LoginBox.BackColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("Поле ввода логина пустое!", "Ошибка");
                    LoginBox.BackColor = Color.RosyBrown;
                    PasswordBox.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Поля ввода логина и пароля пустые!", "Ошибка");
                LoginBox.BackColor = Color.RosyBrown;
                PasswordBox.BackColor = Color.RosyBrown;
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginButton_Click(sender, e);
            }
        }

        private void LoginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
