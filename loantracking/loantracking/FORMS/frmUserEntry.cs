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
    public partial class frmUserEntry : Form
    {
        public frmUserEntry()
        {
            InitializeComponent();
        }

        private void frmUserEntry_Load(object sender, EventArgs e)
        {
            cl_logIn lg = new cl_logIn();
            txtusername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            cboType.Enabled = false;
            lg.loaduserToListview(listView1, 0);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtPassword.Text = "";
            cboType.Text = "";

            txtusername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            cboType.Enabled = true;
            PUBLIC_VARS.EDITMODE = false;
            txtusername.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cl_logIn lg = new cl_logIn();
            PUBLIC_VARS.EDITMODE = true;
            int uD = Convert.ToInt32(listView1.SelectedItems[0].Text);
            txtusername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            cboType.Enabled = true;
            lg.loadUSer(uD);
            txtusername.Text = lg.username;
            txtPassword.Text = lg.password;
            cboType.Text = lg.utype;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cl_logIn lg = new cl_logIn();
            PUBLIC_VARS.EDITMODE = true;
            if (listView1.SelectedItems.Count != 0)
            {
                int uD = Convert.ToInt32(listView1.SelectedItems[0].Text);
                lg.DeleteUser(uD);
                lg.loaduserToListview(listView1, 0);
                txtusername.Text = "";
                txtPassword.Text = "";
                cboType.Text = "";
            }
            else {
                MessageBox.Show("Please select user to be deleted.");
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cl_logIn lg = new cl_logIn();
            //txtusername.Text = lg.username;
            //txtPassword.Text = lg.password;
            //cboType.Text = lg.utype;

            if(PUBLIC_VARS.EDITMODE == true){

                int uD = Convert.ToInt32(listView1.SelectedItems[0].Text);
                lg.UpdateUser(txtusername.Text, txtPassword.Text, cboType.Text, uD);
                MessageBox.Show(PUBLIC_VARS.updateData);
            }
            else{
                lg.InsertUserId(txtusername.Text, txtPassword.Text, cboType.Text);
                MessageBox.Show(PUBLIC_VARS.saveData);
            }
            txtusername.Text = "";
            txtPassword.Text = "";
            cboType.Text = "";
            lg.loaduserToListview(listView1, 0);
        }
    }
}
