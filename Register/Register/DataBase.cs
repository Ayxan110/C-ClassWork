using System;

namespace Register
{
    static public class DataBase
    {
        private static User[] users;
        private static int counter = 0;
        static DataBase()
        {
            users = new User[1];
            users[0] = new User();
            users[0].name = "Admin";
            users[0].surname = "Admin";
            users[0].email = "admin@gmail.com";
            users[0].password = "12345";
        }

        internal static User[] GetAllUsers()
        {
            return users;
        }

        internal static void AddUsers(User user)
        {
            counter++;
            if (users.Length <= counter)
            {
                Array.Resize(ref users, counter * 2);
            }
            users[counter] = user;
        }
        public static bool CheckUser(string log, string pass)
        {
            foreach (User item in users)
            {
                if (log == item.email && pass == item.password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
