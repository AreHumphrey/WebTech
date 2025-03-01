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

using System.Text.RegularExpressions;
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
           
            this.dataGridView1.Columns["Organization_ID"].Visible =
           false;
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

            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.
            GetString(3), record.GetInt32(4), RoWState.Modified);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select Organization_name, Organization_address, Client_full_name, Client_phone, Organization_ID from Clients";
        SqlCommand command = new SqlCommand(queryString,
dbconnection.getConnection());
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
        private void dataGridView1_CellClick(object sender,
       DataGridViewCellEventArgs e)
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
        //private void RefreshImg_Click(object sender, EventArgs e)
        //{
        // RefreshDataGrid(dataGridView1);
        //}
        private void NewClientButton_Click(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            string name = NameOtextbox.Text;
            string address = AddressOtextbox.Text;
            string fio = ClientFIOtextbox.Text;
            string phone = Phonetextbox.Text;
            string pattern = @"^[А-ЯЁ][а-яё]*(?:\s[А-ЯЁ][а-яё]*){2}?\r?$";
            string pattern1 = @"^[А-ЯЁ][а-яё]*(?:\s[А-ЯЁ][а-яё]*){1}?\r?$";
            string pattern2 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ](((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-9]{0,2}))(,\s{0,1})кв.(\s{0,1}[1-9][0-9]{0,3}),(\s{0,1})([1-9][0-9]{5})(|$)";
            string pattern3 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ][а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))|(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-  9]{0,2}))(,\s{0,1})кв.(\s{0,1}[1-9][0-9]{0,3})(|$)";
            string pattern4 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ][а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))|(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-9]{0,2}))(,\s{0,1})([1-9][0-9]{5})(|$)";
            string pattern5 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ][а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})((((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s(к.|стр.|корпус|строение)\s{0,1}[1-9][0-9]{0,2})|(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))))(|$)";
            string pattern6 = @"\+[?\\7\s]+([\(\s\-]?\d+[\)\s\-]?[\d\s\-]+)?";


 SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
 // Проверка пользователя в БД на Телефон
 DataTable table1 = new DataTable();
 string querystring1 = $"select * from [Clients] whereClient_phone] = '{phone}'";
 SqlCommand sqlCommand1 = new SqlCommand(querystring1,
dbconnection.getConnection());
 sqlDataAdapter1.SelectCommand = sqlCommand1;
 sqlDataAdapter1.Fill(table1);
 if (!string.IsNullOrEmpty(name) && !
string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(fio) && !
string.IsNullOrEmpty(phone))
 {
 if ((Regex.IsMatch(fio, pattern,
RegexOptions.IgnoreCase)) || (Regex.IsMatch(fio, pattern1,
RegexOptions.IgnoreCase)))
 {
 if (Regex.IsMatch(address, pattern2,
RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern3,
RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern4,
RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern5,
RegexOptions.IgnoreCase))
 {
 if (Regex.IsMatch(phone, pattern6,
RegexOptions.IgnoreCase) && Phonetextbox.TextLength == 16)
 {
 if (table1.Rows.Count == 0)
 {
var addQuery = $"insert into Clients(Organization_name, Organization_address, Client_full_name, Client_phone) values('{name}','{address}','{fio}','{phone}')";
                                var command = new SqlCommand(addQuery,
                                dbconnection.getConnection());
                                command.ExecuteNonQuery();
                                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                dbconnection.closeConnection();
                                RefreshDataGrid(dataGridView1);
                                ClearFields();
                                dataGridView1.ClearSelection();
                            }
                            else
                            {
                                MessageBox.Show("В базе уже есть пользователь с таким телефоном!", "Ошибка!", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                                dbconnection.closeConnection();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Телефон введен некорректно, либо же допущены лишние пробелы.Формат телефона: +7(9xx)xxx - xx - xx.",
                           
                            "Проверьте правильность ввода",
                           

                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введенный адрес некорректен. Он должен быть заполнен по следующему шаблону: г.Москва, ул.Бутырки,д.3, кв.124, 390000.Квартиру и индекс можно не заполнять.",
                       
                        "Проверьте правильность ввода.",
                       
                        MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введенное ФИО некорректно. Оно должно состоять из двух(при отсутствии отчества) или трех слов, начинающихся с заглавной буквы",
                   
                    "Проверьте правильность ввода.",
                   
                    MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля для ввода!",
               "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();
            }
        }
        private void ClearImg_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }
        private void AnotherStick_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select Organization_name,Organization_address, Client_full_name, Client_phone, Organization_ID from Clients where concat(Organization_name, Organization_address, Client_full_name, Client_phone, Organization_ID) like '%" + SearchTextBox.Text + "%'";
        SqlCommand com = new SqlCommand(searchString,
dbconnection.getConnection());
            dbconnection.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
            dbconnection.closeConnection();
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs
       e)
        {
            Search(dataGridView1);
        }

        private void Change()
        {
            string name = NameOtextbox.Text;
            string address = AddressOtextbox.Text;
            string fio = ClientFIOtextbox.Text;
            string phone = Phonetextbox.Text;
            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[4,
           selectedRowIDX].Value);
            string pattern = @"^[А-ЯЁ][а-яё]*(?:\s[А-ЯЁ][а-яё]*){2}?\r?$";
            string pattern1 = @"^[А-ЯЁ][а-яё]*(?:\s[А-ЯЁ][а-яё]*){1}?\r?$";
            string pattern2 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|
поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})
([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|
площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ]
75
[а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))|
(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-
9]{0,2}))(,\s{0,1})кв.(\s{0,1}[1-9][0-9]{0,3}),(\s{0,1})([1-9][0-9]{5})(|$)";
            string pattern3 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|
поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})
([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|
площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ]
[а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))|
(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-
9]{0,2}))(,\s{0,1})кв.(\s{0,1}[1-9][0-9]{0,3})(|$)";
            string pattern4 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|
поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})
([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|
площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ]
[а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))|
(((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\s{1}(к.|стр.|корпус|строение)\s{0,1}[1-9][0-
9]{0,2}))(,\s{0,1})([1-9][0-9]{5})(|$)";
            string pattern5 = @"(?i)(\W|^)((г.|п.|пгт.|с.|город|село|
поселок|посёлок|поселок\sгородского\sтипа|посёлок\sгородского\sтипа)(\s{0,1})
([А-ЯЁ][а-яё]*),(\s{0,1})(ул.|пер.|пл.|пр-д.|пр-кт.|ш.|наб.|улица|переулок|
площдь|проезд|проспект|шоссе|набережная)(\s{0,1}))((([А-ЯЁ][а-яё]*)\s{1}([А-ЯЁ]
[а-яё]*))|([А-ЯЁ][а-яё]*)|(([1-9][0-9]{0,3}\s{0,1})[А-ЯЁ][а-яё]*)|(([А-ЯЁ][аяё]*)(\s{0,1}[0-9][1-9]{0,3}))),(\s{0,1})((((д.|дом)(\s{0,1}[1-9][0-9]{0,2}))\
s(к.|стр.|корпус|строение)\s{0,1}[1-9][0-9]{0,2})|(((д.|дом)(\s{0,1}[1-9][0-9]
{0,2}))))(|$)";
            string pattern6 = @"\+[?\\7\s]+([\(\s\-]?\d+[\)\s\-]?[\d\s\-]
+)?";
            if (!string.IsNullOrEmpty(name) && !
string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(fio) && !
string.IsNullOrEmpty(phone))
            {
                dbconnection.openConnection();
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                // Проверка пользователя в БД на Телефон
                DataTable table1 = new DataTable();
                string querystring1 = $"select * from [Clients] where [Organization_ID] = '{aza}'";
 SqlCommand sqlCommand1 = new SqlCommand(querystring1,
dbconnection.getConnection());
                sqlDataAdapter1.SelectCommand = sqlCommand1;
                sqlDataAdapter1.Fill(table1);
                if ((Regex.IsMatch(fio, pattern,
               RegexOptions.IgnoreCase)) || (Regex.IsMatch(fio, pattern1,
               RegexOptions.IgnoreCase)))
                {
                    if (Regex.IsMatch(address, pattern2,
                   RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern3,
                   RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern4,
                   RegexOptions.IgnoreCase) || Regex.IsMatch(address, pattern5,
                   RegexOptions.IgnoreCase))
                    {
                        if (Regex.IsMatch(phone, pattern6,
                       RegexOptions.IgnoreCase) && Phonetextbox.TextLength == 16)
                        {
                        
                        if (table1.Rows.Count == 1)
                            {
                                try
                                {
                                    var addQuery = $"update Clients set Organization_name = '{name}', Organization_address = '{address}', Client_full_name = '{fio}', Client_phone = '{phone}' where Organization_ID ='{aza}'";
                                var command = new
SqlCommand(addQuery, dbconnection.getConnection());
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                                    dbconnection.closeConnection();
                                    RefreshDataGrid(dataGridView1);
                                    ClearFields();
                                    dataGridView1.ClearSelection();
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("Такой телефон уже есть в базе данных!", "Неудача!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Такого клиента нету в базе, чтобы обновлять данные", "Ошибка!", MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Телефон введен некорректно,либо же допущены лишние пробелы.Формат телефона: +7(9xx)xxx - xx - xx.",
                           
                            "Проверьте правильность ввода",
                           

                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введенный адрес некорректен. Он должен быть заполнен по следующему шаблону: г.Москва, ул.Бутырки, д.3, кв.124, 390000.Квартиру и индекс можно не заполнять.",
                       
                        "Проверьте правильность ввода.",
                       
                        MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введенное ФИО некорректно. Оно должно состоять из двух(при отсутствии отчества) или трех слов, начинающихся с заглавной буквы",
                   
                    "Проверьте правильность ввода.",
                    MessageBoxButtons.OK,
MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для обновления!",
               "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChangeClientButton_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void DeleteClient()
        {
            var name = NameOtextbox.Text;
            var address = AddressOtextbox.Text;
            var fio = ClientFIOtextbox.Text;
            var phone = Phonetextbox.Text;
            if (!string.IsNullOrEmpty(name) && !
           string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(fio) && !
           string.IsNullOrEmpty(phone))
            {
                dbconnection.openConnection();
                var addQuery = $"delete from Clients where Client_phone ='{phone}'";
            var command = new SqlCommand(addQuery,
dbconnection.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успех!",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbconnection.closeConnection();
                RefreshDataGrid(dataGridView1);
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления!",
               "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            DeleteClient();
            ClearFields();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}




