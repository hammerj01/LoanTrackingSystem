using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using loantracking.CLASSES;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_borrower_loan
    {
        //schedule_of_payment_id, schedule_date, cust_id, remarks
        //tmoneylender_loan

        private int schedule_of_payment_id;
        private DateTime schedule_date;
        private int cust_id;
        private string remarks;
        private double amountLend;
        string sql = "";
        public int propSchedPaymentID {
            get { return this.schedule_of_payment_id; }
            set { this.schedule_of_payment_id = value; }
        }
        public DateTime propSchedate {
            get { return this.schedule_date; }
            set { this.schedule_date = value; }
        }
        public int propBorrowerID {
            get { return this.cust_id; }
            set { this.cust_id = value; }
        }
        public string propRemarks{
            get { return this.remarks;}
            set {this.remarks = value;}
        }
        public double propAmountLend {
            get { return this.amountLend; }
            set { this.amountLend = value; }
        }

        public void InsertCustLoan(){
            sql = "";
            //schedule_of_payment_id, schedule_date, cust_id, remarks
            sql = "insert into tmoneylender_loan values(null,'" + String.Format("{0:s}", this.propSchedate) + "'," + 
                  " " + this.propBorrowerID + ",'" + this.propRemarks + "'," +this.propAmountLend + ")";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public void UpdateCustLoan() {
            sql = "";
            sql = "update tmoneylender_loan SET remarks = '" + this.propRemarks + "' where cust_id = " + this.propBorrowerID;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void paymntSched(int lenderID) {
            sql = "";
            sql = "select * from tmoneylender_loan where cust_id= " + lenderID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    PUBLIC_VARS.d.reader.Read();
                    propBorrowerID = Convert.ToInt32(PUBLIC_VARS.d.reader["cust_id"].ToString());
                    propRemarks = PUBLIC_VARS.d.reader["remarks"].ToString();
                    propSchedPaymentID = Convert.ToInt32(PUBLIC_VARS.d.reader["schedule_of_payment_id"].ToString());
                    propSchedate =Convert.ToDateTime( PUBLIC_VARS.d.reader["schedule_date"].ToString());
                }

            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public bool checkBorrowerHasLoan(int cust_id ) {

            sql = "";
            sql = "select * from tmoneylender_loan cust_id = " + cust_id;
            PUBLIC_VARS.d.execute(sql);
            return true;

        }

    }
}
