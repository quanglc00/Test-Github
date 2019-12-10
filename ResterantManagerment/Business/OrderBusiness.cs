using ResterantManagerment.DataAccess;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterantManagerment.Business
{
    public class OrderBusiness
    {
        public List<Dish> GetListDish()
        {
            return new OrderDataAccess().GetListDish();
        }
        public Dish GetListById(int id)
        {
            return new OrderDataAccess().GetDishById(id);
        }
    }
}
