using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace plantsVSzombies
{
    class UserOperate
    {
        public List<string> readUser()
        {
            String strLine = null;
            List<string> userList = new List<string>();

        try{
             FileStream aFile = new FileStream("../../user.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                strLine = sr.ReadLine();
                while (strLine != null)
                {
                    userList.Add(strLine);
                    strLine = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IOException has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return null;
            }

             return userList;
        }

        public void addUser(String user)
        {

            try
            {
               
                FileStream aFile = new FileStream("../../user.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(aFile);
                
                sw.WriteLine(user);
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IOException has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}
