using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loantracking.FORMS
{
    public partial class mLoanTracking : Form
    {
        public mLoanTracking()
        {
            InitializeComponent();
        }

        private void moneyLenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMoneyLender f = new frmListMoneyLender();
            f.ShowDialog(); 
        }

        private void loanTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanType l = new frmLoanType();
            l.ShowDialog();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments p = new frmPayments();
            p.ShowDialog();
        }

        private void cIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCI c = new frmCI();
            c.ShowDialog();
        }

        private void collateralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollateral f = new frmCollateral();
            f.ShowDialog();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplyLoan apl = new frmApplyLoan();
            apl.ShowDialog();
        }
    }
}
