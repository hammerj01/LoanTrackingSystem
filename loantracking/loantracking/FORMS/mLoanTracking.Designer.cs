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
            this.loanTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collateralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMoneyLenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.listOfCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.inquiryToolStripMenuItem});
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
            this.cIToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // moneyLenderToolStripMenuItem
            // 
            this.moneyLenderToolStripMenuItem.Name = "moneyLenderToolStripMenuItem";
            this.moneyLenderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moneyLenderToolStripMenuItem.Text = "MoneyLender";
            this.moneyLenderToolStripMenuItem.Click += new System.EventHandler(this.moneyLenderToolStripMenuItem_Click);
            // 
            // loanTypeToolStripMenuItem
            // 
            this.loanTypeToolStripMenuItem.Name = "loanTypeToolStripMenuItem";
            this.loanTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loanTypeToolStripMenuItem.Text = "Loan Type";
            this.loanTypeToolStripMenuItem.Click += new System.EventHandler(this.loanTypeToolStripMenuItem_Click);
            // 
            // collateralToolStripMenuItem
            // 
            this.collateralToolStripMenuItem.Name = "collateralToolStripMenuItem";
            this.collateralToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.collateralToolStripMenuItem.Text = "Collateral";
            this.collateralToolStripMenuItem.Click += new System.EventHandler(this.collateralToolStripMenuItem_Click);
            // 
            // cIToolStripMenuItem
            // 
            this.cIToolStripMenuItem.Name = "cIToolStripMenuItem";
            this.cIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cIToolStripMenuItem.Text = "C.I.";
            this.cIToolStripMenuItem.Click += new System.EventHandler(this.cIToolStripMenuItem_Click);
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
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // inquiryToolStripMenuItem
            // 
            this.inquiryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfMoneyLenderToolStripMenuItem,
            this.toolStripMenuItem4,
            this.listOfCIToolStripMenuItem});
            this.inquiryToolStripMenuItem.Name = "inquiryToolStripMenuItem";
            this.inquiryToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.inquiryToolStripMenuItem.Text = "Inquiry";
            // 
            // listOfMoneyLenderToolStripMenuItem
            // 
            this.listOfMoneyLenderToolStripMenuItem.Name = "listOfMoneyLenderToolStripMenuItem";
            this.listOfMoneyLenderToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listOfMoneyLenderToolStripMenuItem.Text = "List of MoneyLender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1495, 741);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // listOfCIToolStripMenuItem
            // 
            this.listOfCIToolStripMenuItem.Name = "listOfCIToolStripMenuItem";
            this.listOfCIToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.listOfCIToolStripMenuItem.Text = "List of C.I";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
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
            this.Text = "mLoanTracking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}