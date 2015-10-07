using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using loantracking.CLASSES;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_payment
    {
        //payment_id, amount, date_paid, remarks
        //tpayment

        //moneylender_payment_id, moneylender_id, payment_id, date_paid, remarks
        //tmoneylender_payment

        private int payment_id;
        private double amount = 0d;
        private string remarks;
        private int mlender_paymentID;
        private DateTime datepaid;
        private int lenderID;


        public int propLenderID
        {
            get { return this.lenderID; }
            set { this.lenderID = value; }
        }
        public int propIDs
        {
            get { return this.payment_id; }
            set { this.payment_id = value; }
        }
        public double propAMOUNT {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public string PROPREMARKS {
            get { return this.remarks; }
            set { this.remarks = value; }
        }
        public DateTime propDatepaid {
            get { return this.datepaid; }
            set { this.datepaid = value; }
        }
        public int propmlenderPaymentID {
            get { return this.mlender_paymentID; }
            set { this.mlender_paymentID = value; }
        }

        //payment_id, amount, date_paid, remarks
        //tpayment

        public void insertpayments() {
            string sql = "";
            sql = "insert into tpayment values(null,'" + this.propAMOUNT + "','" +String.Format("{0:s}",DateTime.Today) + "','" + this.PROPREMARKS + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        
        
        //moneylender_payment_id, moneylender_id, payment_id, date_paid, remarks
        //tmoneylender_payment
        public void insertmoneylenderpayment() {
            string sql = "";
            sql = "insert into tmoneylender_payment values(null," + this.propLenderID + "," + this.propmlenderPaymentID + "," +
                  "'" +String.Format("{0:s}", DateTime.Today) +"','" + this.PROPREMARKS +"')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

    }
}
