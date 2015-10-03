using System;
using System.Collections.Generic;
using System.Text;
using loantracking.CLASSES;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking
{
    class cl_lender_inform : cl_moneylender
    {
        private int money_lender_id;
        private int loan_id;
        private string loan_status;
        private string sql = "";
    
        public int propMoneyLenderID
        {
            get
            {
                return this.money_lender_id;
            }
            set
            {
                this.money_lender_id = value;
            }
        }

        public int propLoan_id
        {
            get
            {
                return this.loan_id;
            }
            set
            {
                this.loan_id = value;
            }
        }

        public string propStatus
        {
            get
            {
                return this.loan_status;
            }
            set
            {
                this.loan_status = value;
            }
        }
    
        public void INSERT_LENDER_INFORM()
        {
            //moneylender_loan_ID, loan_id, moneylender_id, status
            //tmoneylender_loan

            sql = "";
            sql = "INSERT INTO tmoneylender_loan VALUES(NULL,  " + this.propLoan_id + " , " + this.propMoneyLender_id + "," +
                  "'" + this.propStatus + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void UPDATE_LENDER_INFORM(int m_ID)
        {
            sql = "";
            sql = "update tmoneylender_loan SET loan_id = " + this.propLoan_id + ", '" + this.propMoneyLender_id + ", '" + this.propStatus + "' where moneylender_loan_ID = "+ m_ID ;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public bool HAS_ACTIVELOAN(int lender_id)
        {
            bool jhun = false;
            sql = "";
            sql = "select * from tmoneylender_loan where  moneylender_id = " + lender_id;
            PUBLIC_VARS.d.execute(sql);

        
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    PUBLIC_VARS.d.reader.Read();        
                    PUBLIC_VARS.d.reader.Close();
                    jhun = true;
                }

                if (jhun == true)
                {
                    return true;
                }
                else {
                    return false;
                }

        }
    }
}
