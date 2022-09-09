using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstEtüt.Repositories
{

    public class EmployeeRepository
    {
        NorthwindEntities db;

        public EmployeeRepository()
        {
            db = new NorthwindEntities();
        }
        //Bir metodum olsun bana Employee listesini döndürsün.

        //SELECT * FROM EMPLOYEES

        public List<Employee> GetEmployees()
        {
            List<Employee> emps = new List<Employee>();
            emps = db.Employees.ToList();

            return emps;

            // ya da db.Employees.ToList();
        }
    }
}
