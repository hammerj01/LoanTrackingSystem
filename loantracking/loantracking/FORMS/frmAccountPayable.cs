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
    public partial class frmAccountPayable : Form
    {
        public frmAccountPayable()
        {
            InitializeComponent();
        }

        private void frmAccountPayable_Load(object sender, EventArgs e)
        {
            int dt;
            int yr;
            MYFUNCTIONS f = new MYFUNCTIONS();
            double mntDue = 0d;
            dt = 0;
            yr = 0;
            f.acctPayable(lsvBCollection, dt, yr);
            label3.Text ="Total no. of barrowers :" + lsvBCollection.Items.Count.ToString();

            if(lsvBCollection.SelectedItems.Count > -1){

                for (int c = 0; c <= lsvBCollection.Items.Count -1; c++)
                //MessageBox.Show(lsvBCollection.Items[c].SubItems[4].ToString());
                {
                    double ham = 0d;
                    ham = Convert.ToDouble(lsvBCollection.Items[c].SubItems[4].Text);
                    mntDue = mntDue + ham;
                }
            }


            label4.Text = "Total Account's Payable : " + String.Format("{0:#,##0.00}", mntDue); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dt;
            int yr;
            double mntDue = 0d;
            MYFUNCTIONS f = new MYFUNCTIONS();

            dt = dateTimePicker1.Value.Month;
            yr = dateTimePicker1.Value.Year;
            f.acctPayable(lsvBCollection, dt,yr);

            if (lsvBCollection.SelectedItems.Count > -1)
            {

                for (int c = 0; c <= lsvBCollection.Items.Count - 1; c++)
                //MessageBox.Show(lsvBCollection.Items[c].SubItems[4].ToString());
                {
                    double ham = 0d;
                    ham = Convert.ToDouble(lsvBCollection.Items[c].SubItems[4].Text);
                    mntDue = mntDue + ham;
                }
                label4.Text = "Total Account's Payable : " + String.Format("{0:#,##0.00}", mntDue);
            }

        }
    }
}
