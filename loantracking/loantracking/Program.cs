using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using loantracking.FORMS;
using loantracking.CLASSES;
using MySql.Data.MySqlClient;
using loantracking.FORMS;
namespace loantracking
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
            //Application.Run(new Form1());

            PUBLIC_VARS.d._server = "localhost";
            PUBLIC_VARS.d._user = "root";
            PUBLIC_VARS.d._pw = "";
            PUBLIC_VARS.d._db = "dbtracking";

            if(PUBLIC_VARS.d.connect()){
                mLoanTracking frm = new mLoanTracking();
                frm.ShowDialog();
            }

        }
    }
}
