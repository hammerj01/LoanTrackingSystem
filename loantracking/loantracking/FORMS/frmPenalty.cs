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
    public partial class frmPenalty : Form
    {
        public frmPenalty()
        {
            InitializeComponent();
        }
        int pubID = 0;
        private void frmPenalty_Load(object sender, EventArgs e)
        {
            MYFUNCTIONS f = new MYFUNCTIONS();
            f.PopulateListView(listView1, "select * from tpenalty");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PUBLIC_VARS.EDITMODE = false;
            txtpenalty.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cl_Penalty p = new cl_Penalty();
            PUBLIC_VARS.EDITMODE = true;
            pubID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            p.loadFieldToPenalty(pubID);
            txtpenalty.Text = p.propPenalty_amount.ToString("#,##0.00");
            cboRemarks.Text = p.propPenalty_remarks;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cl_Penalty p = new cl_Penalty();
            MYFUNCTIONS f = new MYFUNCTIONS();
            
            int pubIDel = Convert.ToInt32(listView1.SelectedItems[0].Text);
            p.propPenalty_Id = pubIDel;
            p.delete_penalty();
            f.PopulateListView(listView1, "Select * from tpenalty");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MYFUNCTIONS f = new MYFUNCTIONS();
            cl_Penalty p = new cl_Penalty();
            p.propPenalty_amount =Convert.ToDouble(txtpenalty.Text);


            if ((cboRemarks.Text == "Active") || (cboRemarks.Text == "Pending"))
            {

            }
            else {
                MessageBox.Show("Please select the remarks.");
                return;
            }


            if (PUBLIC_VARS.EDITMODE == true)
            {
                if (p.countActive(cboRemarks.Text) == true )
                {
                    MessageBox.Show("Please set only 1 active penalty");
                    return;
                }

                p.propPenalty_Id = pubID;
                p.propPenalty_remarks = cboRemarks.Text;
                p.update_penalty();
                MessageBox.Show(PUBLIC_VARS.updateData);
                f.PopulateListView(listView1, "Select * from tpenalty");
            }
            else
            {
                if (p.countActive(cboRemarks.Text) == true )
                {
                    MessageBox.Show("Please set only 1 active penalty");
                    return;
                }


                p.propPenalty_remarks = cboRemarks.Text;
                p.INSERT_PENALTY();
               MessageBox.Show( PUBLIC_VARS.saveData);
               f.PopulateListView(listView1, "Select * from tpenalty");
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //cl_Penalty p = new cl_Penalty();
            //PUBLIC_VARS.EDITMODE = true;
            //pubID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            //p.loadFieldToPenalty(pubID);
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
