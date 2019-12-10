using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment.DataAccess
{
    public class OrderDataAccess
    {
        ManagerResterant db = null;
        public List<Dish> GetListDish()
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    return db.Dishes.ToList();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public Dish GetDishById(int id)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    return db.Dishes.Find(id);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
