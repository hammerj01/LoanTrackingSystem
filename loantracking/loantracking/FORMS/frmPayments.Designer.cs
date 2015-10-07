namespace loantracking.FORMS
{
    partial class frmPayments
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
            this.lbldatenow = new System.Windows.Forms.Label();
            this.txtborrwersName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlenderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvLender = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.txtAmountApplied = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonthlyDues = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAmountTerder = new System.Windows.Forms.TextBox();
            this.bntCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldatenow
            // 
            this.lbldatenow.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatenow.Location = new System.Drawing.Point(511, 12);
            this.lbldatenow.Name = "lbldatenow";
            this.lbldatenow.Size = new System.Drawing.Size(172, 30);
            this.lbldatenow.TabIndex = 36;
            this.lbldatenow.Text = "Date now";
            // 
            // txtborrwersName
            // 
            this.txtborrwersName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtborrwersName.Location = new System.Drawing.Point(288, 58);
            this.txtborrwersName.Name = "txtborrwersName";
            this.txtborrwersName.Size = new System.Drawing.Size(384, 23);
            this.txtborrwersName.TabIndex = 35;
            this.txtborrwersName.TextChanged += new System.EventHandler(this.txtborrwersName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Borrower\'s Name :";
            // 
            // txtlenderID
            // 
            this.txtlenderID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlenderID.Location = new System.Drawing.Point(12, 58);
            this.txtlenderID.Name = "txtlenderID";
            this.txtlenderID.Size = new System.Drawing.Size(256, 23);
            this.txtlenderID.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Borrowers ID :";
            // 
            // lsvLender
            // 
            this.lsvLender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lsvLender.FullRowSelect = true;
            this.lsvLender.GridLines = true;
            this.lsvLender.Location = new System.Drawing.Point(12, 315);
            this.lsvLender.Name = "lsvLender";
            this.lsvLender.Size = new System.Drawing.Size(384, 273);
            this.lsvLender.TabIndex = 40;
            this.lsvLender.UseCompatibleStateImageBehavior = false;
            this.lsvLender.View = System.Windows.Forms.View.Details;
            this.lsvLender.Visible = false;
            this.lsvLender.SelectedIndexChanged += new System.EventHandler(this.lsvLender_SelectedIndexChanged);
            this.lsvLender.DoubleClick += new System.EventHandler(this.lsvLender_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 380;
            // 
            // txtAmountApplied
            // 
            this.txtAmountApplied.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountApplied.Location = new System.Drawing.Point(12, 217);
            this.txtAmountApplied.Name = "txtAmountApplied";
            this.txtAmountApplied.Size = new System.Drawing.Size(312, 33);
            this.txtAmountApplied.TabIndex = 42;
            this.txtAmountApplied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Amount :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(12, 111);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(656, 68);
            this.txtAddress.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Address :";
            // 
            // txtMonthlyDues
            // 
            this.txtMonthlyDues.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyDues.Location = new System.Drawing.Point(356, 217);
            this.txtMonthlyDues.Name = "txtMonthlyDues";
            this.txtMonthlyDues.Size = new System.Drawing.Size(312, 33);
            this.txtMonthlyDues.TabIndex = 46;
            this.txtMonthlyDues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonthlyDues.TextChanged += new System.EventHandler(this.txtMonthlyDues_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Monthly Dues :";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalty.Location = new System.Drawing.Point(12, 276);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(312, 33);
            this.txtPenalty.TabIndex = 48;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Penalty Amount :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Amount Tendered :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(462, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 38);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "&PAY";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmountTerder
            // 
            this.txtAmountTerder.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTerder.Location = new System.Drawing.Point(356, 276);
            this.txtAmountTerder.Name = "txtAmountTerder";
            this.txtAmountTerder.Size = new System.Drawing.Size(312, 33);
            this.txtAmountTerder.TabIndex = 57;
            this.txtAmountTerder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountTerder.TextChanged += new System.EventHandler(this.txtAmountTerder_TextChanged);
            this.txtAmountTerder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountTerder_KeyPress);
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(570, 339);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(102, 38);
            this.bntCancel.TabIndex = 58;
            this.bntCancel.Text = "&CLEAR";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 389);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.txtAmountTerder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonthlyDues);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmountApplied);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvLender);
            this.Controls.Add(this.lbldatenow);
            this.Controls.Add(this.txtborrwersName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlenderID);
            this.Controls.Add(this.label5);
            this.Name = "frmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldatenow;
        private System.Windows.Forms.TextBox txtborrwersName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlenderID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsvLender;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtAmountApplied;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonthlyDues;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAmountTerder;
        private System.Windows.Forms.Button bntCancel;
    }
}