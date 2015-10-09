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

        private void penaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenalty p = new frmPenalty();
            p.ShowDialog();
        }

        private void listOfMoneyLenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMoneyLender l = new frmListMoneyLender();

            l.ShowDialog();
        }

        private void listOfCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenalty p = new frmPenalty();
            p.ShowDialog();
        }

        private void accountsRecievableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListofBorrower ar = new frmListofBorrower();
            ar.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to logout?", "logout", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.Hide();
                frmUserLogin usr = new frmUserLogin();
                usr.ShowDialog();
            }
        }

        private void mLoanTracking_Load(object sender, EventArgs e)
        {
           // double pen = 0d;

        }

        private void accountsPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountPayable p = new frmAccountPayable();
            p.ShowDialog();
        }
    }
}
