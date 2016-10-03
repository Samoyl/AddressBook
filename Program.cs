using System;
using System.Windows.Forms;
using AddressBook.Configuration;
using StructureMap;

namespace AddressBook
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Bootstrapper.ConfigureStructureMap(ObjectFactory.Container);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());                   
        }
    }
}