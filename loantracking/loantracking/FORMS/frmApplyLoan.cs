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
using System.Globalization;



namespace loantracking.FORMS
{
    public partial class frmApplyLoan : Form
    {
        int mYLenderIDs;
        List<double> lstamt = new List<double>();
        List<string> lstdatesched = new List<string>();
        public frmApplyLoan()
        {
            InitializeComponent();
        }

        private void frmApplyLoan_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 10);
            lbldatenow.Text = DateTime.Now.ToString("D");
            //MYFUNCTIONS m = new MYFUNCTIONS();
            //m.PopulateListView(lsvPaymentSched, "select * from tschedule_of_payment");
            txtMonthsNo.Text = "36";
 

            //double pmt = 0.015 * 75000 * Math.Pow((1 + 0.015), 36);
            //double pmt1 = Math.Pow((1 + 0.015), 18) - 1;
            //double pmt_ans = pmt / pmt1;
            //MessageBox.Show(pmt_ans.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cl_moneylender cl = new cl_moneylender();
            cl.SearchLenderByName(textBox1.Text, lsvLender);
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                this.lsvLender.BringToFront();
                this.lsvLender.Location = new Point(282, 79);
                this.lsvLender.Visible = true;
            }
            else if(textBox1.Text == "")
            {
                this.lsvLender.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

         
        }

        private void lsvLender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvLender_DoubleClick(object sender, EventArgs e)
        {
            cl_moneylender ml = new cl_moneylender();
            int ml_ID = Convert.ToInt32(lsvLender.SelectedItems[0].Text);
            mYLenderIDs = ml_ID;
            ml.LOADTOFIELDS(ml_ID);
            textBox1.Text = ml.propfname + " " + ml.propMI + " " + ml.proplname;
            txtlenderID.Text = ml.propLenderID; 
            this.lsvLender.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            cl_lender_inform lend = new cl_lender_inform();
            //less 1 mo. interest = 1.5%
            //charges = 5%
            double amt_applied = 0d;
            int no_ofDays = 0;

            if (textBox1.Text == "") {
                MessageBox.Show("Please supply the borrowers name.");
                return;
            }
            if(Convert.ToDouble(txtAmountApplied.Text)<=0){
                MessageBox.Show("Please supply the correct amount.");
                return;
            }
            amt_applied = Convert.ToDouble(txtAmountApplied.Text);
            double charges = (amt_applied * 5) / 100;
            double rest1 = (amt_applied * 1.5) / 100;
            double net_proceeds = amt_applied - (rest1+charges);
            int termsNo;
            int monthstoPay;

            txtNetAmount.Text = net_proceeds.ToString("#,###0.00");

            DateTime timenow = DateTime.Today;
            try
            {
                termsNo = Convert.ToInt32(txtMonthsNo.Text);
                if (txtMonthsNo.Text == "")
                {
                    termsNo = 36;
                }
            }
            catch (Exception xx) {
                termsNo = 36;
            }

          
            lsvPaymentSched.Items.Clear();
            DateTime today = DateTime.Today;
            List<DateTime> lstq = new List<DateTime>();

            if (termsNo > 36) {
                MessageBox.Show("Invalid amount.");
                return;
            }
            else if(termsNo < 0){
                termsNo = 36;
            }
            
            int ctr;
            for ( ctr= 1; ctr <= termsNo; ctr++)
                {
                    lstq.Add(timenow.AddMonths(ctr).AddDays(-1));
                }
         
           
            double getamnt = Convert.ToDouble(txtAmountApplied.Text);
            double pmt = 0d;
            double pmt1 = 0d;
      
            double restDue = 0d;
            double re = 0d;
            double getamnt1 = 0d;
            double mntDue = Convert.ToDouble(txtMonthlyDue.Text);
            restDue = getamnt;
            double tmp = 0d;
            monthstoPay = 0;

                foreach (DateTime eel in lstq)
                {
                    ListViewItem lvi1 = new ListViewItem();
                    DateTime lastDayOfThisMonth = new DateTime(eel.Year, eel.Month, 1).AddMonths(1).AddDays(-1);
                    
                   lvi1.Text = lastDayOfThisMonth.ToString("D");
                   lstdatesched.Add(lastDayOfThisMonth.ToString());
                   no_ofDays = Convert.ToInt32(lastDayOfThisMonth.Day.ToString());

                   pmt = 0.015 / 30;
                   pmt1 = pmt * no_ofDays;
                   getamnt1 = getamnt * pmt1;
                   re = (mntDue) - getamnt1;
                   tmp = getamnt;
                   getamnt = getamnt - re;
                    
                  
                   lvi1.SubItems.Add(mntDue.ToString("#,###0.00"));
                   monthstoPay = monthstoPay + 1;
                   lstamt.Add(getamnt);
                  if (getamnt <= 0)
                   {
                       
                       lvi1.SubItems.Add("0.00".ToString());
                       txtmonthstopay.Text = monthstoPay - 1 + " " + "Months to pay";
                       lsvPaymentSched.Items.Add(lvi1);
                       return;
                   }
                   else
                   {
                       lvi1.SubItems.Add(getamnt.ToString("#,###0.00"));
                   }
                   lvi1.SubItems.Add("Pending");
                   lsvPaymentSched.Items.Add(lvi1);
                    //schedule_of_payment_id, schedule_date, cust_id, remarks

                }

        }

        private void txtMonthsNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            //    e.Handled = true;

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

        private void txtMonthsNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountApplied_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            cl_lender_inform lenderIn = new cl_lender_inform();
            try
            {
                if (lenderIn.PEND_ACTIVELOAN(mYLenderIDs) == true)
                {
                    MessageBox.Show("Please settle your loan first. " );
                   
                }
                else
                {
                    cl_lender_inform lend = new cl_lender_inform();
                    cl_borrower_loan bl = new cl_borrower_loan();
                   // int ml_ID = Convert.ToInt32(lsvLender.SelectedItems[0].Text);

                     List<DateTime> lstq = new List<DateTime>();
 
                    for (int i = 0; i < lstamt.Count; i++)
                    {
                        lend.propDbalance = lstamt[i];
                        //lend.propiTerest =    ;
                        //    lend.propPrinc = ;
                        lend.propMnt_amount = Convert.ToDouble(txtMonthlyDue.Text);
                        lend.propLoan_id = 2;
                        lend.propStatus = "Pending";
                        lend.propMoneyLender_id = mYLenderIDs;
                        lend.propPrinc = Convert.ToDouble(lsvPaymentSched.Items[i].SubItems[2].Text);
                        lend.propSchedate = Convert.ToDateTime(lsvPaymentSched.Items[i].Text.ToString());
                        lend.propHpenalty = 0.0;
                        lend.INSERT_LENDER_INFORM(); // tschedule_of_payment
                        
                        //bl.propRemarks = "Pending";
                        //bl.propBorrowerID = mYLenderIDs;
                        //bl.propSchedate =Convert.ToDateTime(lsvPaymentSched.Items[i].Text.ToString());
                        //bl.propAmountLend = Convert.ToDouble(txtAmountApplied.Text);

                        //bl.InsertCustLoan();  // tmoneylender_loan
                    }
                    bl.propRemarks = "Pending";
                    bl.propBorrowerID = mYLenderIDs;
                    bl.propSchedate = DateTime.Today; //Convert.ToDateTime(lsvPaymentSched.Items[i].Text.ToString());
                    bl.propAmountLend = Convert.ToDouble(txtAmountApplied.Text);
                    bl.InsertCustLoan();  // tmoneylender_loan
                    MessageBox.Show("Loan has been approve.");
                    this.Hide();
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMonthlyDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonthlyDue_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAmountApplied_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
