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
    public partial class frmPayments : Form
    {
        int mYLenderIDs;
        public frmPayments()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if(Convert.ToDouble(txtMonthlyDues.Text) > Convert.ToDouble(txtAmountTerder.Text)){
                MessageBox.Show("The monthly dues should not be greater than amount tendered.");
                return;
            }
            cl_payment p = new cl_payment();
            //payment_id, amount, date_paid, remarks
            //tpayment

            p.propAMOUNT = Convert.ToDouble(txtAmountTerder.Text);
            p.PROPREMARKS = "paid";
            p.insertpayments();

            int getpaidIDs = PUBLIC_VARS.d.getlastid();
            p.propLenderID = mYLenderIDs;
            p.propmlenderPaymentID = getpaidIDs;
            p.PROPREMARKS = "paid";
            p.insertmoneylenderpayment();

            //moneylender_payment_id, moneylender_id, payment_id, date_paid, remarks
            //tmoneylender_payment
            cl_lender_inform lend = new cl_lender_inform();
            //tschedule_of_payment
            lend.updateRemarkSP(mYLenderIDs);

            MessageBox.Show("Successfully save.");
            this.Hide();
        }

        private void txtborrwersName_TextChanged(object sender, EventArgs e)
        {
            cl_moneylender cl = new cl_moneylender();
            cl.SearchLenderByName(txtborrwersName.Text, lsvLender);
            if (!string.IsNullOrEmpty(txtborrwersName.Text))
            {
                this.lsvLender.BringToFront();
                this.lsvLender.Location = new Point(285, 79);
                this.lsvLender.Visible = true;
            }
            else if (txtborrwersName.Text == "")
            {
                this.lsvLender.Visible = false;
            }
        }

        private void lsvLender_DoubleClick(object sender, EventArgs e)
        {
            cl_moneylender ml = new cl_moneylender();
            cl_lender_inform lendIn = new cl_lender_inform();

            int ml_ID = Convert.ToInt32(lsvLender.SelectedItems[0].Text);
            mYLenderIDs = ml_ID;
            ml.LOADTOFIELDS(ml_ID);
            txtborrwersName.Text = ml.propfname + " " + ml.propMI + " " + ml.proplname;
            txtlenderID.Text = ml.propLenderID;
            txtAddress.Text = ml.propAddress;
            lendIn.PaySched(ml_ID);
            
         
    
            txtPenalty.Text = lendIn.propHpenalty.ToString("#,##0.00");
            this.lsvLender.Visible = false;
            cl_lender_inform le = new cl_lender_inform();

            le.hasBorrowerPenalty(ml_ID);
            txtAmountApplied.Text = lendIn.propPrinc.ToString("#,##0.00");
            double xd = lendIn.propMnt_amount + lendIn.propHpenalty;
            txtMonthlyDues.Text = xd.ToString("#,##0.00");
        }

        private void lsvLender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            lbldatenow.Text = DateTime.Today.ToShortDateString();


            //System.DateTime firstDate = new System.DateTime(2000, 01, 01);
            //System.DateTime secondDate = new System.DateTime(2000, 05, 31);

            //System.TimeSpan diff = secondDate.Subtract(firstDate);
            //System.TimeSpan diff1 = secondDate - firstDate;

            //String diff2 = (secondDate - firstDate).TotalDays.ToString();

            //MessageBox.Show(diff1.ToString());

        }

        private void txtMonthlyDues_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountTendered_TextChanged(object sender, EventArgs e)
        {
           
            }

        private void txtAmountTerder_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountTerder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtAmountApplied.Text = "";
            txtAmountTerder.Text = "";
            txtborrwersName.Text = "";

        }

        }

    
    }

