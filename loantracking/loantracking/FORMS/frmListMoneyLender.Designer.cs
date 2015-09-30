namespace loantracking.FORMS
{
    partial class frmListMoneyLender
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
            this.lsvMoneyLender = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMoneyLender
            // 
            this.lsvMoneyLender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5});
            this.lsvMoneyLender.FullRowSelect = true;
            this.lsvMoneyLender.GridLines = true;
            this.lsvMoneyLender.Location = new System.Drawing.Point(0, 0);
            this.lsvMoneyLender.Name = "lsvMoneyLender";
            this.lsvMoneyLender.Size = new System.Drawing.Size(1052, 477);
            this.lsvMoneyLender.TabIndex = 0;
            this.lsvMoneyLender.UseCompatibleStateImageBehavior = false;
            this.lsvMoneyLender.View = System.Windows.Forms.View.Details;
            this.lsvMoneyLender.SelectedIndexChanged += new System.EventHandler(this.lsvMoneyLender_SelectedIndexChanged);
            this.lsvMoneyLender.DoubleClick += new System.EventHandler(this.lsvMoneyLender_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MoneylenderID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Lender ID";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Age";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Credit Limit";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Contact No.";
            this.columnHeader7.Width = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(802, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(930, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmListMoneyLender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 537);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsvMoneyLender);
            this.Name = "frmListMoneyLender";
            this.Text = "frmListMoneyLender";
            this.Load += new System.EventHandler(this.frmListMoneyLender_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ListView lsvMoneyLender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}