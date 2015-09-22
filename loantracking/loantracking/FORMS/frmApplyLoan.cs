using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using loantracking.CLASSES;
using loantracking.FORMS;

namespace loantracking.FORMS
{
    public partial class frmApplyLoan : Form
    {
        public frmApplyLoan()
        {
            InitializeComponent();
        }

        private void frmApplyLoan_Load(object sender, EventArgs e)
        {
            lbldatenow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            MYFUNCTIONS m = new MYFUNCTIONS();
            m.PopulateListView(lsvPaymentSched, "select * from tschedule_of_payment");
        }
    }
}
