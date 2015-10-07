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
    public partial class frmCI : Form
    {
        //cl_myCI ci = new cl_myCI();
        cl_myCI ci = new cl_myCI();
        public frmCI()
        {
            InitializeComponent();
        }

        private void frmCollateral_Load(object sender, EventArgs e)
        {
            ci.LOAD_LISTs(lsvCI);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFname.Focus();
            PUBLIC_VARS.EDITMODE = false;
        }

        private void lsvCI_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.EDITMODE = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cl_myCI c = new cl_myCI();
            c.propfname = txtFname.Text;
            c.proplname = txtLname.Text;
            c.propAddress = txtAddress.Text;
            c.contact_no = txtContact.Text;
            if (PUBLIC_VARS.EDITMODE == true){
                int x = Convert.ToInt32(lsvCI.SelectedItems[0].Text.ToString());
                c.propCI_id = x;
                c.UPDATE_DATAs();
                MessageBox.Show( PUBLIC_VARS.updateData);
            }else{
                c.INSERT_DATAs();
                MessageBox.Show(PUBLIC_VARS.saveData);
            }
            c.LOAD_LISTs(lsvCI);
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cl_myCI ct = new cl_myCI();
           

            DialogResult result1 = MessageBox.Show("Are you sure you want to delete entry?",
"Important Question",
MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                ct.propCI_id = Convert.ToInt32(lsvCI.SelectedItems[0].Text.ToString());
                ci.DELETE_DATAs();
                MessageBox.Show(PUBLIC_VARS.deleteData);
                ct.LOAD_LISTs(lsvCI);
            }
            

        }

        private void lsvCI_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.activeID = Convert.ToInt32(lsvCI.SelectedItems[0].Text.ToString());
            ci.LOAD_FIELDSs(PUBLIC_VARS.activeID);
            txtFname.Text = ci.propfname;
            txtLname.Text = ci.proplname;
            txtAddress.Text = ci.propAddress;
            txtContact.Text = ci.propContact_no;
        }
    }
}
