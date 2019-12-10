using ResterantManagerment.DataAccess;

namespace ResterantManagerment.Business
{
    public class UserBusiness
    {
        public int Login(string userName, string passWord)
        {
            return new UserDataAccess().Login(userName, passWord);
        }
    }
}
