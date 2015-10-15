using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace loantracking.REPORTS
{
    public partial class frmBarrowersPayable : Form
    {
        public frmBarrowersPayable()
        {
            InitializeComponent();
        }

        private void frmBarrowersPayable_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\MY PROJECTS\LoanTrackingSystem\loantracking\loantracking\REPORTS\CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
