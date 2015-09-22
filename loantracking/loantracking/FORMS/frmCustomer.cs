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
    public partial class frmCustomer : Form
    {
     
        public ListView lsvevent = new ListView();
        public Int32 mlt;
        public frmCustomer()
        {
            InitializeComponent();
        }

 
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if(PUBLIC_VARS.EDITMODE == true){
                cl_moneylender cm = new cl_moneylender();
                cm.LOADTOFIELDS(mlt);
                txtAddress.Text = cm.propAddress;
                txtFname.Text = cm.propfname;
                txtLname.Text = cm.proplname;
                txtMI.Text = cm.propMI;
                txtAge.Text =cm.propAge.ToString();
                txtCreditLimit.Text = cm.propCreditLimit.ToString();
                txtContactNo.Text = cm.propContact_no;
                txtMoneyLenderID.Text = cm.propLenderID;
  
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            cl_moneylender cMoneyLender = new cl_moneylender();
            cMoneyLender.propfname = txtFname.Text;
            cMoneyLender.proplname = txtLname.Text;
            cMoneyLender.propMI = txtMI.Text;
            cMoneyLender.propAddress = txtAddress.Text;
            cMoneyLender.propAge = Convert.ToInt32(txtAge.Text);
            cMoneyLender.propCreditLimit = Convert.ToDouble(txtCreditLimit.Text);
            cMoneyLender.propLenderID = txtMoneyLenderID.Text;
            cMoneyLender.propContact_no = txtContactNo.Text;

            if (cMoneyLender.propAge < 18)
            {
                MessageBox.Show("Age should not lesser than 18");
                return;
            }
            if (PUBLIC_VARS.EDITMODE == true){
                
                cMoneyLender.UPDATE_DATA(mlt);
                MessageBox.Show( PUBLIC_VARS.updateData);
            }
            else{
                cMoneyLender.INSERT_DATA();
               MessageBox.Show(PUBLIC_VARS.saveData);
            }
            //cMoneyLender.LOAD_MONEYLENDER(lst.lsvMoneyLender);
            //MYFUNCTIONS m = new MYFUNCTIONS();
            //string sql = "SELECT * FROM tmoneylender";
            //m.PopulateListView(lsvevent,sql);
            cMoneyLender.LOAD_MONEYLENDER(lsvevent);
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



 
    }
}
