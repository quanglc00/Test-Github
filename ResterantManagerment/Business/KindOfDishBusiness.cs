using ResterantManagerment.DataAccess;
using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterantManagerment.Business
{
    class KindOfDishBusiness
    {
        public List<KindOfDish> getList()
        {
            return new KindOfDishDataAccess().getListKindOfDish();
        }
        public bool AddKind(KindOfDish d)
        {
            return new KindOfDishDataAccess().AddKind(d);
        }
        public bool UpdateKind(KindOfDish d)
        {
            return new KindOfDishDataAccess().UpdateKind(d);
        }
        public bool DeleteKind(int id)
        {
            return new KindOfDishDataAccess().DeleteKind(id);
        }
    }
}
