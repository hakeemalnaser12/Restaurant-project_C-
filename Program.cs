﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Res_csharp.Model;


namespace Res_csharp
{
   
    static class Program
    {
     
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login_Cashier());
        }
    }
}
