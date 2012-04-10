using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountManager.Model
{

    class User
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string Name { set; get; }
        public DateTime CreationDate { set; get; }

        public User(String usrname, String passwd, String name, DateTime crDate)
        {
            Username = usrname;
            Password = passwd;
            Name = name;
            CreationDate = crDate;
        }

        public User(String usrname, String passwd, String name)
        {
            Username = usrname;
            Password = passwd;
            Name = name;
            CreationDate = DateTime.Now;
        }
    }
}
