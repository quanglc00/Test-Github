using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResterantManagerment.DataAccess
{
    class KindOfDishDataAccess
    {
        ManagerResterant MR; 
        public List<KindOfDish> getListKindOfDish()
        {
            using (MR = new ManagerResterant())
            {
                try
                {
                    return MR.KindOfDishes.ToList();
                }
                catch (Exception e )
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }
        public bool AddKind(KindOfDish kd)
        {
            try
            {
                using (MR = new ManagerResterant())
                {
                    MR.KindOfDishes.Add(kd);
                    MR.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool UpdateKind(KindOfDish kd)
        {
            try
            {
                using (MR = new ManagerResterant())
                {
                    KindOfDish d = MR.KindOfDishes.SingleOrDefault(x => x.KindOfDishId == kd.KindOfDishId);
                    d.Name = kd.Name;
                    MR.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool DeleteKind(int id)
        {
            try
            {
                using (MR = new ManagerResterant())
                {
                    KindOfDish d = MR.KindOfDishes.Find(id);
                    MR.KindOfDishes.Remove(d);
                    MR.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
