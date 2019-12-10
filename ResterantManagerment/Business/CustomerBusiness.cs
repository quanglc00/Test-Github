using ResterantManagerment.DataAccess;
using ResterantManagerment.Emtity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ResterantManagerment.Business
{
    public class CustomerBusiness
    {
        
        public List<Customer> GetListCustomer()
        {
            try
            {
                return new CustomerDataAccess().GetListCustomer();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool AddCustomer(Customer a)
        {
            try
            {
                return new CustomerDataAccess().AddCustomer(a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateCustomer(Customer a)
        {
            try
            {
                return new CustomerDataAccess().UpdateCustomer(a);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteCustomer(int id)
        {
            try
            {
                return new CustomerDataAccess().DeleteCustomer(id);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
