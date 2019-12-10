using ResterantManagerment.DataAccess;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment.Business
{
    public class DishBusiness
    {
        ManagerResterant db = null;
        DishDataAccess dda = new DishDataAccess();
        public List<Dish> GetListDish()
        {
            return dda.GetListDish();
        }
        public bool AddDish(Dish e)
        {
            return dda.AddDish(e);
        }
        public bool UpdateDish(Dish e)
        {
            return dda.UpdateDish(e);
        }
        public bool DeleteDish(int id)
        {
            return dda.DeleteDish(id);
        }
    }
}
