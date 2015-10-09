namespace loantracking.FORMS
{
    partial class mLoanTracking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mLoanTracking));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyLenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loanTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collateralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMoneyLenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsRecievableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.listOfCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountsPayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.inquiryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moneyLenderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loanTypeToolStripMenuItem,
            this.collateralToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cIToolStripMenuItem,
            this.penaltyToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // moneyLenderToolStripMenuItem
            // 
            this.moneyLenderToolStripMenuItem.Name = "moneyLenderToolStripMenuItem";
            this.moneyLenderToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.moneyLenderToolStripMenuItem.Text = "Borrower";
            this.moneyLenderToolStripMenuItem.Click += new System.EventHandler(this.moneyLenderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 6);
            // 
            // loanTypeToolStripMenuItem
            // 
            this.loanTypeToolStripMenuItem.Name = "loanTypeToolStripMenuItem";
            this.loanTypeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loanTypeToolStripMenuItem.Text = "Loan Type";
            this.loanTypeToolStripMenuItem.Click += new System.EventHandler(this.loanTypeToolStripMenuItem_Click);
            // 
            // collateralToolStripMenuItem
            // 
            this.collateralToolStripMenuItem.Name = "collateralToolStripMenuItem";
            this.collateralToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.collateralToolStripMenuItem.Text = "Collateral";
            this.collateralToolStripMenuItem.Click += new System.EventHandler(this.collateralToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 6);
            // 
            // cIToolStripMenuItem
            // 
            this.cIToolStripMenuItem.Name = "cIToolStripMenuItem";
            this.cIToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cIToolStripMenuItem.Text = "C.I.";
            this.cIToolStripMenuItem.Click += new System.EventHandler(this.cIToolStripMenuItem_Click);
            // 
            // penaltyToolStripMenuItem
            // 
            this.penaltyToolStripMenuItem.Name = "penaltyToolStripMenuItem";
            this.penaltyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.penaltyToolStripMenuItem.Text = "Penalty";
            this.penaltyToolStripMenuItem.Click += new System.EventHandler(this.penaltyToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanToolStripMenuItem,
            this.toolStripMenuItem1,
            this.paymentToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // inquiryToolStripMenuItem
            // 
            this.inquiryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfMoneyLenderToolStripMenuItem,
            this.accountsPayableToolStripMenuItem,
            this.accountsRecievableToolStripMenuItem,
            this.toolStripMenuItem4,
            this.listOfCIToolStripMenuItem});
            this.inquiryToolStripMenuItem.Name = "inquiryToolStripMenuItem";
            this.inquiryToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inquiryToolStripMenuItem.Text = "Inquiry";
            // 
            // listOfMoneyLenderToolStripMenuItem
            // 
            this.listOfMoneyLenderToolStripMenuItem.Name = "listOfMoneyLenderToolStripMenuItem";
            this.listOfMoneyLenderToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listOfMoneyLenderToolStripMenuItem.Text = "List of Borrowers";
            this.listOfMoneyLenderToolStripMenuItem.Click += new System.EventHandler(this.listOfMoneyLenderToolStripMenuItem_Click);
            // 
            // accountsRecievableToolStripMenuItem
            // 
            this.accountsRecievableToolStripMenuItem.Name = "accountsRecievableToolStripMenuItem";
            this.accountsRecievableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.accountsRecievableToolStripMenuItem.Text = "Collections";
            this.accountsRecievableToolStripMenuItem.Click += new System.EventHandler(this.accountsRecievableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 6);
            // 
            // listOfCIToolStripMenuItem
            // 
            this.listOfCIToolStripMenuItem.Name = "listOfCIToolStripMenuItem";
            this.listOfCIToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.listOfCIToolStripMenuItem.Text = "List of Penalty";
            this.listOfCIToolStripMenuItem.Click += new System.EventHandler(this.listOfCIToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 701);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // accountsPayableToolStripMenuItem
            // 
            this.accountsPayableToolStripMenuItem.Name = "accountsPayableToolStripMenuItem";
            this.accountsPayableToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.accountsPayableToolStripMenuItem.Text = "Accounts Payable";
            this.accountsPayableToolStripMenuItem.Click += new System.EventHandler(this.accountsPayableToolStripMenuItem_Click);
            // 
            // mLoanTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mLoanTracking";
            this.Text = "Loan Tracking System.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mLoanTracking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyLenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collateralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMoneyLenderToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem listOfCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsRecievableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsPayableToolStripMenuItem;
    }
}