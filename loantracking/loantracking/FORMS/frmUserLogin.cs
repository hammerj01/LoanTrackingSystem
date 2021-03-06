﻿using System;
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
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            //user_id, username, password, utype
            string type = "";
            if (txtpassword.Text == "" || txtusername.Text == "")
            {
                MessageBox.Show("Please supply the missing fields.");
                return;
            }
            bool s = false;
            string sql = "SELECT * from tuser where username= '" + this.txtusername.Text + "' && password = '" +this.txtpassword.Text + "'";
            PUBLIC_VARS.d.execute(sql);
           

            if (PUBLIC_VARS.d.reader.HasRows)
            {
                PUBLIC_VARS.d.reader.Read();
                        s = true;
                  type = PUBLIC_VARS.d.reader["utype"].ToString();
            }
            PUBLIC_VARS.d.reader.Close();
            if (s)
            {
               
                this.Hide();
                mLoanTracking mf = new mLoanTracking();
                type = type.ToLower();
                if (type.Equals("guest"))
                {
                //    mf.maintainanceToolStripMenuItem.Enabled = false;
                //    mf.transactionToolStripMenuItem.Enabled = false;
                //    mf.createActivityToolStripMenuItem.Enabled = false;
                    mf.MainMenuStrip.Items[0].Visible = false;
                    mf.MainMenuStrip.Items[1].Visible = false;
                    mf.MainMenuStrip.Items[2].Visible = false;
          
                
                }
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username/or password.");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
