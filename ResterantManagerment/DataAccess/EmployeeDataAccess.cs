using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment.DataAccess
{
    public class EmployeeDataAccess
    {
        ManagerResterant MR = new ManagerResterant();
        public EmployeeDataAccess()
        {

        }
        public List<Employee> getListEmployee()
        {
            using (MR= new ManagerResterant())
            {
                try
                {
                    List<Employee> ds= MR.Employees.ToList();
                    //ds.Add
                    //foreach (Employee item in ds)
                    //{

                    //}
                    return ds;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }
        public bool AddEmployee(Employee e)
        {
            using (MR =  new ManagerResterant())
            {
                try
                {
                    var result = MR.Employees.Add(e);
                    MR.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;   
                }
            }
        }
        public bool UpdateEmployee(Employee e)
        {
            using (MR= new ManagerResterant())
            {
                try
                {
                    Employee ts = MR.Employees.SingleOrDefault(x => x.EmployeeId == e.EmployeeId);
                    ts.EmployeeName = e.EmployeeName;
                    ts.Gender = e.Gender;
                    ts.Adress = e.Adress;
                    ts.Age = e.Age;
                    ts.Email = e.Email;
                    ts.Phone = e.Phone;
                    MR.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public bool DeleteEmployee(int id)
        {
            using (MR = new ManagerResterant())
            {
                try
                {
                    Employee employee = MR.Employees.SingleOrDefault(x => x.EmployeeId == id);
                    MR.Employees.Remove(employee);
                    MR.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                    throw;
                }
            }
        }
    }   
}
