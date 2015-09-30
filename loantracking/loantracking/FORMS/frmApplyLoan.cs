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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cl_moneylender cl = new cl_moneylender();
            cl.SearchLenderByName(textBox1.Text, lsvLender);
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                this.lsvLender.BringToFront();
                this.lsvLender.Location = new Point(282, 106);
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
            ml.LOADTOFIELDS(ml_ID);
            textBox1.Text = ml.propfname + " " + ml.propMI + " " + ml.proplname;
            txtlenderID.Text = ml.propLenderID; 
            this.lsvLender.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            double amt_applied = 0d;

            amt_applied = Convert.ToDouble(txtAmountApplied.Text);

        }
    }
}
