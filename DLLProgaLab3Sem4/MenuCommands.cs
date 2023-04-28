using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLL
{
    public class MenuCommands
    {
        public void Others(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли разное");
        }
        public void Stuff(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли информацию о сотрудниках");
        }
        public void Orders(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли приказы");
        }
        public void Docs(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли документы");
        }
        public void Departs(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли отделы");
        }
        public void Towns(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли информацию о городах");
        }
        public void Posts(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли информацию о должниках");
        }
        public void Window(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли окна");
        }
        public void Content(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли оглавление");
        }
        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли информацию о программе");
        }
        public void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Вы открыли помощь");
        }      
    }
}
