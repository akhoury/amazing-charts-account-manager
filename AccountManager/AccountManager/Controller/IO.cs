using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace AccountManager.Controller
{
    class IO
    {
        private static readonly string XML_DIR = "people.xml";
        private static readonly string CSV_DIR = "people.csv";

        public static List<Model.User> readXML()
        {
            List<Model.User> users = new List<Model.User>();
            // Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create(XML_DIR))
            {
                string element = "", username = "", password = "", name = "";
                DateTime creationDate = DateTime.Now;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        element = reader.Name;
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                    {
                        switch (element)
                        {
                            case "Username":
                                username = reader.Value;
                                break;
                            case "Password":
                                password = reader.Value;
                                break;
                            case "Name":
                                name = reader.Value;
                                break;
                            case "CreationDate":
                                creationDate = DateTime.Parse(reader.Value);
                                break;

                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        element = reader.Name;
                        if (element == "User")
                        {
                            Model.User u = new Model.User(username, password, name, creationDate);
                            users.Add(u);
                        }
                    }

                }


            }
            return Persistent.sortByName(users);
        }

        public static void writeXML(List<Model.User> users)
        {
            // Create an XML writer for this file.
            using (XmlWriter writer = XmlWriter.Create(XML_DIR))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Users");

                foreach (Model.User user in users)
                {
                    writer.WriteStartElement("User");

                    writer.WriteElementString("Username", user.Username);
                    writer.WriteElementString("Password", user.Password);
                    writer.WriteElementString("Name", user.Name);
                    writer.WriteElementString("Date", user.CreationDate.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        public static List<Model.User> readCSV()
        {
            List<Model.User> users = new List<Model.User>();

            try
            {
                using (StreamReader readFile = new StreamReader(CSV_DIR))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        Model.User user = new Model.User(row[0], row[1], row[2], DateTime.Parse(row[3]));
                        users.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return Persistent.sortByName(users);

        }

        public static void writeCSV(List<Model.User> users)
        {
            StringBuilder myString = new StringBuilder();

            if (File.Exists(CSV_DIR))
            {
                File.Delete(CSV_DIR);
            }
            StreamWriter sw = new StreamWriter(CSV_DIR, true);

            foreach (Model.User user in users)
            {
                    myString.Append(user.Username + ",");
                    myString.Append(user.Password + ",");
                    myString.Append(user.Name + ",");
                    myString.Append(user.CreationDate.ToString() + ",");
                    myString.Append("\r\n");
            }
            sw.WriteLine(myString.ToString());
            sw.Close();
            GC.Collect();
        }
    }
}
