using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechDep
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем БД и таблицы перед запуском приложения
            DBConnection db = new DBConnection();
            db.CreateDatabase();
            db.CreateTables();
            db.AddEmployee("jora", "Jane Smith", "System Administrator", "+0987654321", "5f4dcc3b5aa765d61d8327deb882cf99", 1)
            Application.Run(new AuthenticateForm());
        }
    }
}
