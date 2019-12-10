using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ResterantManagerment.DataAccess
{
    public class CustomerDataAccess
    {
        ManagerResterant db = null;
        public List<Customer> GetListCustomer()
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    return db.Customers.ToList();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public bool AddCustomer(Customer a)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    var result = db.Customers.Add(a);
                    db.SaveChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return true;
        }
        public bool UpdateCustomer(Customer a)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    var newCustomer = db.Customers.SingleOrDefault(x => x.CustomerId == a.CustomerId);
                    newCustomer.CustomerName = a.CustomerName;
                    newCustomer.PhoneNumber = a.PhoneNumber;
                    newCustomer.Email = a.Email;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public Customer GetCustomerById(int id)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    return db.Customers.Find(id);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public bool DeleteCustomer(int id)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    var customer = db.Customers.SingleOrDefault(x => x.CustomerId == id);
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
    }
}
