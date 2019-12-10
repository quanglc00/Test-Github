using ResterantManagerment.DataAccess;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment.Business
{
    public class EmployeeBusiness
    {
        public void LoadData(DataGridView dgv)
        {
            EmployeeDataAccess dta = new EmployeeDataAccess();
        }
        public List<Employee> GetListEmployee()
        {
            return new EmployeeDataAccess().getListEmployee();
        }
        public bool AddEmployee(Employee e)
        {
            return new EmployeeDataAccess().AddEmployee(e);
        }
        public bool UpdateEmployee(Employee e)
        {
            return new EmployeeDataAccess().UpdateEmployee(e);
        }
        public bool DeleteEmployee(int e)
        {
            return new EmployeeDataAccess().DeleteEmployee(e);
        }
        public EmployeeBusiness() { }
    }
}
