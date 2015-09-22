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
    public partial class frmListMoneyLender : Form
    {
        public frmListMoneyLender()
        {
            InitializeComponent();
        }

        private void frmListMoneyLender_Load(object sender, EventArgs e)
        {
            cl_moneylender cMoneyLender = new cl_moneylender();
            cMoneyLender.LOAD_MONEYLENDER(lsvMoneyLender);
            //MYFUNCTIONS m = new MYFUNCTIONS();
            //string sql = "select * from tmoneylender";
            //m.PopulateListView(lsvMoneyLender, sql);

        }

        private void lsvMoneyLender_DoubleClick(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            PUBLIC_VARS.EDITMODE = true;
            PUBLIC_VARS.activeID = Convert.ToInt32( lsvMoneyLender.SelectedItems[0].Text.ToString());
            c.mlt = PUBLIC_VARS.activeID;
            c.lsvevent = this.lsvMoneyLender;
            c.ShowDialog();
   
        }

        private void lsvMoneyLender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomer Cs = new frmCustomer();
            Cs.lsvevent = this.lsvMoneyLender;
            Cs.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.activeID = Convert.ToInt32(lsvMoneyLender.SelectedItems[0].Text.ToString());
            cl_moneylender cMoneyLender = new cl_moneylender();
            cMoneyLender.DELETE_DATA(PUBLIC_VARS.activeID);
            MessageBox.Show(PUBLIC_VARS.deleteData);

            cMoneyLender.LOAD_MONEYLENDER(lsvMoneyLender);
        }
    }
}