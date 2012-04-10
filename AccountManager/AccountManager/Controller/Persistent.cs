using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager.Controller
{
    class Persistent
    {
        public static List<Model.User> Users { set; get; }

        public static void deleteUser(Model.User user, int storage)
        {
            Users.Remove(user);
            if (storage == 1)
            {
                Controller.IO.writeXML(Users);
            }
            else if (storage == 2)
            {
                Controller.IO.writeCSV(Users);
            }

        }

        public static void addUser(Model.User user, int storage)
        {
            Users.Add(user);
            Users = sortByName(Users);
            if (storage == 1)
            {
                Controller.IO.writeXML(Users);
            }
            else if (storage == 2)
            {
                Controller.IO.writeCSV(Users);
            }
        }

        public static void editUser(Model.User newuser, int i, int storage)
        {
            Users[i] = newuser;
            Users = sortByName(Users);
            if (storage == 1)
            {
                Controller.IO.writeXML(Users);
            }
            else if (storage == 2)
            {
                Controller.IO.writeCSV(Users);
            }

        }

        public static List<Model.User> sortByName(List<Model.User> users)
        {
            var alphabetical = from element in users
                               orderby element.Name
                               select element;
            return alphabetical.ToList<Model.User>();

        }

    }
}
