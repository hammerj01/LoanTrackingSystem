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
    public partial class frmListMoneyLender : Form
    {
        public frmListMoneyLender()
        {
            InitializeComponent();
        }

        private void frmListMoneyLender_Load(object sender, EventArgs e)
        {
            cl_moneylender cMoneyLender = new cl_moneylender();
            cMoneyLender.LOAD_MONEYLENDER(lsvMoneyLender);
            //MYFUNCTIONS m = new MYFUNCTIONS();
            //string sql = "select * from tmoneylender";
            //m.PopulateListView(lsvMoneyLender, sql);

        }

        private void lsvMoneyLender_DoubleClick(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            PUBLIC_VARS.EDITMODE = true;
            PUBLIC_VARS.activeID = Convert.ToInt32( lsvMoneyLender.SelectedItems[0].Text.ToString());
            c.mlt = PUBLIC_VARS.activeID;
            c.lsvevent = this.lsvMoneyLender;
            c.ShowDialog();
   
        }

        private void lsvMoneyLender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomer Cs = new frmCustomer();
            Cs.lsvevent = this.lsvMoneyLender;
            Cs.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            if (lsvMoneyLender.SelectedItems.Count > 0)
            {

                PUBLIC_VARS.activeID = Convert.ToInt32(lsvMoneyLender.SelectedItems[0].Text.ToString());
                cl_moneylender cMoneyLender = new cl_moneylender();
                DialogResult result1 = MessageBox.Show("Are you sure you want to delete entry?", "delete", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    cMoneyLender.DELETE_DATA(PUBLIC_VARS.activeID);
                    MessageBox.Show(PUBLIC_VARS.deleteData);
                }
                cMoneyLender.LOAD_MONEYLENDER(lsvMoneyLender);
            }
            else {
                MessageBox.Show("No records to be deleted.");
            }
            
    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             cl_moneylender l = new cl_moneylender();
             l.Search_MONEYLENDER(lsvMoneyLender,textBox1.Text);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            cl_moneylender l = new cl_moneylender();
            l.Search_MONEYLENDER(lsvMoneyLender, "view");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cl_moneylender l = new cl_moneylender();
            l.Search_MONEYLENDER(lsvMoneyLender, textBox1.Text);
        }

        private void cboBtype_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cboBtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cl_moneylender l = new cl_moneylender();
            l.LOAD_MONEYLENDER_Actvie(lsvMoneyLender, cboBtype.Text);
        }
    }
}