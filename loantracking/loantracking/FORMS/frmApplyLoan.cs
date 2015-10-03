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
        int mYLenderIDs = 0;
        public frmApplyLoan()
        {
            InitializeComponent();
        }

        private void frmApplyLoan_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 10);
            lbldatenow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            MYFUNCTIONS m = new MYFUNCTIONS();
            m.PopulateListView(lsvPaymentSched, "select * from tschedule_of_payment");
            txtMonthsNo.Text = "36";
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
            //less 1 mo. interest = 1.5%
            //charges = 5%
            double amt_applied = 0d;
            int no_ofDays = 0;
            double rest = 0d;
            amt_applied = Convert.ToDouble(txtAmountApplied.Text);
            double charges = (amt_applied * 5) / 100;
        
            //double rest = (amt_applied * 1.5) / 100;
            //double charges = (amt_applied * 5) / 100;

            double net_proceeds = amt_applied - (rest+charges);
            txtNetAmount.Text = net_proceeds.ToString();

         //   MessageBox.Show(rest.ToString() + "= " + charges.ToString() + "= " + net_proceeds.ToString());
            //var dat = new DateTime(2015, 12, 31);
            DateTime timenow = DateTime.Today;
            int termsNo = Convert.ToInt32(txtMonthsNo.Text);
            lsvPaymentSched.Items.Clear();
            DateTime today = DateTime.Today;
            List<DateTime> lstq = new List<DateTime>();
            for (int ctr = 1; ctr <= termsNo; ctr++)
                {
                   
                    lstq.Add(timenow.AddMonths(ctr).AddDays(-1));
                }

                int jh = 0;
              
                foreach (DateTime eel in lstq)
                {
                    ListViewItem lvi1 = new ListViewItem();
                    DateTime lastDayOfThisMonth = new DateTime(eel.Year, eel.Month, 1).AddMonths(1).AddDays(-1);
                    
                   lvi1.Text = lastDayOfThisMonth.ToString("D");
                   no_ofDays = Convert.ToInt32(lastDayOfThisMonth.Day.ToString());
                   if (no_ofDays <= 30)
                   {
                       rest = (amt_applied * 1.5) / 100;

                   }
                   else
                   {
                       rest = amt_applied * 0.055;
                   }
                   jh = jh + 1;

                   lvi1.SubItems.Add(rest.ToString() + " = " + no_ofDays.ToString());
                   lvi1.SubItems.Add("Pending" + " = " + jh) ;
                   lsvPaymentSched.Items.Add(lvi1);
                }



        }

        private void txtMonthsNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            //    e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
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
                if (lenderIn.HAS_ACTIVELOAN(mYLenderIDs) == true)
                {

                }
                else
                {
                    MessageBox.Show("No active records.");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
