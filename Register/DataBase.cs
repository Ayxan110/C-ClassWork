using System.Collections;

namespace Register
{
    public class DataBase
    {

        static private readonly ArrayList Users;
        static DataBase()
        {
            Users = new ArrayList();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public static bool CheckUser(string login, string pass)
        {
            foreach (User item in Users)
            {
                if (login == item.email && pass == item.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
