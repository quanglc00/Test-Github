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
    class DishDataAccess
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
        public bool AddDish(Dish e)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    var result = db.Dishes.Add(e);
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
        public bool UpdateDish(Dish e)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    Dish dish = db.Dishes.SingleOrDefault(x => x.DishId == e.DishId);
                    dish.DishName = e.DishName;
                    dish.Price = e.Price;
                    dish.KindOfDishId = e.KindOfDishId;
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
        public bool DeleteDish(int id)
        {
            using (db = new ManagerResterant())
            {
                try
                {
                    Dish dish = db.Dishes.Find(id);
                    db.Dishes.Remove(dish);
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
    }
}
