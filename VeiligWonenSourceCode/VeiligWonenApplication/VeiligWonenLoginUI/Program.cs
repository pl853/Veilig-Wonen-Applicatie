using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeiligWonenLoginUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUI());

            //Connection strings : 
            //Pieter  :  Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\piete\OneDrive\Documents\Projects\Overig\VeiligWonenApplicatie\VeiligWonenDatabse\VeiligWonenDataBase.mdf;Integrated Security=True;Connect Timeout=30
            //Suraj : 
            //Asjad :
            //Zahir : 
        }
    }
}
