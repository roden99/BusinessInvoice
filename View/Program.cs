using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    class Program : WindowsFormsApplicationBase
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new Program();
            app.EnableVisualStyles = true;
            app.ShutdownStyle = ShutdownMode.AfterAllFormsClose;

            app.MainForm = new frmLogin();

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-AU");

            app.Run(args);
        }
    }
}
