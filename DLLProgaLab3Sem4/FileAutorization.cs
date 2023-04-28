using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL
{
    public class FileAutorization
    {
        string _filePath;

        public FileAutorization(string filePath)
        {
            _filePath = filePath;
        }
        public bool Autorization(string userName, string Password, out string menuPath)
        {
            FileInfo f = new FileInfo(_filePath);
            menuPath = "";

            if (userName == "" || Password == "")
            {
                MessageBox.Show("Не введен логин или пароль");
                return false;
            }

            using (StreamReader sr = new StreamReader(f.OpenRead(), Encoding.UTF8))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(new char[] { ' ' });

                    string name = splitLine[0];
                    string password = splitLine[1];
                    menuPath = splitLine[2];

                    if (name == userName && password == Password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        
    }
}
