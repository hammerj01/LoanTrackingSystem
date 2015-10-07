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
    public partial class frmDetailsBorrower : Form
    {
        public string bid;
        public frmDetailsBorrower()
        {
            InitializeComponent();
        }

        private void frmDetailsBorrower_Load(object sender, EventArgs e)
        {
            cl_moneylender lender = new cl_moneylender();
            cl_lender_inform li = new cl_lender_inform();

            lender.LOADTOFIELDSLenderID(bid);
            lblAddress.Text = lender.propAddress;
            lblContact.Text = lender.propContact_no;
            lblName.Text = lender.propfname.ToString() + " " + lender.propMI.ToString() + " "  + lender.proplname.ToString();

            li.loadDetailsBorrowers(lsvPaymentSched, lender.propMoneyLender_id);

        }
    }
}
