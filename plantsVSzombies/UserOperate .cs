using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace plantsVSzombies
{
    class UserOperate
    {
        //读取
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
        //增加
        public bool addUser(String user)
        {
            
            if (this.readUser()!=null&&this.readUser().Contains(user)) { return false; }
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
                
            }
            return true;
        }
        //删除
        public void deleteUser(String user)
        {
            List<string> list = readUser();
            list.Remove(user);
            FileStream aFile = new FileStream("../../user.txt", FileMode.Truncate);
            StreamWriter sw = new StreamWriter(aFile);
            foreach (string s in list)
            {

                sw.WriteLine(s);
            }
            sw.Close();//必须close一下，将流中的缓存写入文件，不然文件中无数据
        }
        //
    }
}
