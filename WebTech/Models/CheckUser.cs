using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDep
{
    public class CheckUser
    {
        public string Login { get; set; }
        public bool IsAdmin { get; }
        public string Status => IsAdmin ? "Admin" : "User";
        public int Employee_ID { get; }

        public CheckUser(string login, bool isAdmin, int empID)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
            Employee_ID = empID;
        }
    }
}
