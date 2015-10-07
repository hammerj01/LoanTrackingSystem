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
    public partial class frmCollateral : Form
    {
        public frmCollateral()
        {
            InitializeComponent();
        }

        private void frmCollateral_Load(object sender, EventArgs e)
        {
            cl_collateral cl = new cl_collateral();
            cl.LOAD_LSV(lsvCollateral);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.EDITMODE = false;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.EDITMODE = true;

        }

        public void getData() {
            cl_collateral colla = new cl_collateral();
            txtName.Text = colla.propCollateral_name;
            txtDescription.Text = colla.propCollateral_description;
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            cl_collateral colla = new cl_collateral();
            colla.propCollateral_description = txtDescription.Text;
            colla.propCollateral_name = txtName.Text;
            if (PUBLIC_VARS.EDITMODE == true)
            {
                int x = Convert.ToInt32(lsvCollateral.SelectedItems[0].Text.ToString());
                colla.propCollateral_id = x;
                colla.UPDATA_DATA();
                MessageBox.Show(PUBLIC_VARS.updateData);

            }
            else {
                colla.INSERT_DATACollateral();
                MessageBox.Show(PUBLIC_VARS.saveData);
            }
            colla.LOAD_LSV(lsvCollateral);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this record?", "delete", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                cl_collateral colla = new cl_collateral();
                int x = Convert.ToInt32(lsvCollateral.SelectedItems[0].Text.ToString());
                colla.propCollateral_id = x;
                colla.DELETE_DATA();
                MessageBox.Show(PUBLIC_VARS.deleteData);
                colla.LOAD_LSV(lsvCollateral);
            }
        }
    }
}
