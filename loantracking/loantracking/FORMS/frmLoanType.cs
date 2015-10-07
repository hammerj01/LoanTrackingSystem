using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using loantracking.CLASSES;

namespace loantracking.FORMS
{
    public partial class frmLoanType : Form
    {
        MYFUNCTIONS mFuntion = new MYFUNCTIONS();
        cl_loans l = new cl_loans();
        public ListView lst = new ListView();
        public frmLoanType()
        {
            InitializeComponent();
        }

        private void frmLoanType_Load(object sender, EventArgs e)
        {
           // mFuntion.PopulateListView(lsvLoan, "SELECT * FROM tloan");
            l.LOADAllFields(this.lsvLoan);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.EDITMODE = false;
            txtLoanType.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Int32 loanID = 0;
            getData();
            if (PUBLIC_VARS.EDITMODE == true)
            {
                loanID = Convert.ToInt32(lsvLoan.SelectedItems[0].Text.ToString());
                l.propLoan_id = loanID;
                l.UPDATE_DATA();
                MessageBox.Show(PUBLIC_VARS.updateData);
               

            }
            else {
                
                l.INSERT_DATA();
                MessageBox.Show(PUBLIC_VARS.saveData);
                
            }
        
            txtDescription.Clear();
            txtLoanType.Clear();

            l.LOADAllFields(this.lsvLoan);


        }

        public void getData() {
           
            l.propLoan_type = txtLoanType.Text;
            l.propLoand_desc = txtDescription.Text;
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.activeID = Convert.ToInt32(lsvLoan.SelectedItems[0].Text.ToString());
            PUBLIC_VARS.EDITMODE = true;
            cl_loans ln = new cl_loans();
            ln.LOAD_FIELDS(PUBLIC_VARS.activeID);
            txtDescription.Text = ln.propLoand_desc;
            txtLoanType.Text = ln.propLoan_type;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this record?","delete",MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes){
            PUBLIC_VARS.activeID = Convert.ToInt32(lsvLoan.SelectedItems[0].Text.ToString());
            l.DELETE_DATA(PUBLIC_VARS.activeID);
            l.LOADAllFields(this.lsvLoan);
            }



        }
    }
}
