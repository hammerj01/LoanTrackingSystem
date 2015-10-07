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
    public partial class frmListofBorrower : Form
    {
        public frmListofBorrower()
        {
            InitializeComponent();
        }
       

        private void frmListofBorrower_Load(object sender, EventArgs e)
        {
            MYFUNCTIONS f = new MYFUNCTIONS();
            string sql="";
            //tmoneylender
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit, contact_no, lenderID
            
            //schedule_of_payment_id, schedule_date, cust_id, remarks, amount_lend
            //tmoneylender_loan

            //moneylender_loan_ID, loan_id, moneylender_id, status, mnt_amount, principal
            //tschedule_of_payment

            sql = "select b.lenderID,CONCAT(b.fname, ' ', b.mi, ' ' , b.lname) as NAME,b.address,b.contact_no," +
                  "(sum(sp.mnt_amount)+ sum(sp.penalty_amount)) as spcollection from tmoneylender b " +
                   "inner join  tschedule_of_payment sp on b.moneylender_id = sp.moneylender_id "+
                  "where sp.status = 'paid'";
            f.PopulateListView(lsvBCollection,sql);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string mid;
            if (lsvBCollection.SelectedItems.Count > 0 )
            {
               mid = lsvBCollection.SelectedItems[0].Text;
               frmDetailsBorrower dtb = new frmDetailsBorrower();
               dtb.bid = mid;
               dtb.ShowDialog();
            }
        }
    }
}
