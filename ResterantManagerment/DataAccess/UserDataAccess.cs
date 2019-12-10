using ResterantManagerment.Emtity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterantManagerment.DataAccess
{
    public class UserDataAccess
    {
        ManagerResterant db = null;
        public int Login(string userName, string passWord)
        {
            using (db = new ManagerResterant())
            {
                var result = db.Users.SingleOrDefault(x => x.UserName == userName);
                if (result == null)
                {
                    return 0;
                }
                else
                {
                    if (result.Password != passWord)
                    {
                        return -1;
                    }
                    return 1;
                }
            }
        }
    }
}
