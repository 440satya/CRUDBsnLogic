using CRUDdtLogic;
using CRUDdtLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBsnLogic
{
    public class EmployeeBussinessLogic
    {
        public static bool AddEmployee(string name, string gender, decimal salary)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                throw new ArgumentException("Name and gender cannot be empty.");
            }
            return true;
        }
        public List<EmployeeDt> GetTopEmployees(int count)
        {
            EmployeeDataLogic dataAccess = new EmployeeDataLogic();
            return dataAccess.GetTopEmployees(count);
        }

        public List<EmployeeDt> GetEmployees(int count)
        {
             
            EmployeeDataLogic dataAccess = new EmployeeDataLogic();
            return dataAccess.GetTopEmployees(count);
        }
    }

}
