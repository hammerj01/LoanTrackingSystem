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
        private double mnt_amount = 0d;
        private double iTerest = 0d;
        private double princ = 0d;
        private double dbalance = 0d;

        public double propiTerest
        {

            get { return this.iTerest; }
            set { this.iTerest = value; }
        }
        public double propPrinc
        {

            get { return this.princ; }
            set { this.princ = value; }
        }
        public double propDbalance
        {

            get { return this.dbalance; }
            set { this.dbalance = value; }
        }


        public double propMnt_amount
        {

            get { return this.mnt_amount; }
            set { this.mnt_amount = value; }
        }

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

        private double hpenalty=0d;
        private DateTime schedule_date;
        public double propHpenalty{
            get { return this.hpenalty; }
            set { this.hpenalty = value; }
        }
        public DateTime propSchedate
        {
            get { return this.schedule_date; }
            set { this.schedule_date = value; }
        }
        double balance_amount = 0d;
        public double propBalanceAmount {
            get { return this.balance_amount; }
            set { this.balance_amount = value; }
        }

        public void INSERT_LENDER_INFORM()
        {
            //moneylender_loan_ID, loan_id, moneylender_id, status, mnt_amount, principal, penalty_amount, schedule_date
            //tmoneylender_loan

            sql = "";
            sql = "INSERT INTO tschedule_of_payment VALUES(NULL,  " + this.propLoan_id + " , " + this.propMoneyLender_id + "," +
                  "'" + this.propStatus + "'," + this.propMnt_amount + "," + this.propPrinc + ","+
                  " " + this.propHpenalty+",'"+ String.Format("{0:s}", this.propSchedate) +"'," + this.balance_amount + " )";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void updateRemarkSP(int lenderID)
        {
            sql = "";
            sql = "select * from tschedule_of_payment where moneylender_id = " + lenderID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        if (PUBLIC_VARS.d.reader["status"].ToString() == "Pending")
                        {
                            int temps = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_loan_ID"].ToString());
                            PUBLIC_VARS.d.reader.Close();
                            string sql2 = "update tschedule_of_payment set status = 'Paid' where moneylender_loan_ID = " + temps;
                            PUBLIC_VARS.d.execute(sql2);
                            PUBLIC_VARS.d.reader.Close();
                            return;
                        }
                    }
                }
            }
            catch (Exception xd) { MessageBox.Show(xd.Message); }
        }

        public void PaySched(int lenderID) {
            sql = "";
            //moneylender_loan_ID, loan_id, moneylender_id, status, mnt_amount, principal, penalty_amount, schedule_date
            string rems = "Pending";
            sql = "select * from tschedule_of_payment where moneylender_id = "+ lenderID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if(PUBLIC_VARS.d.reader.HasRows)
                    while (PUBLIC_VARS.d.reader.Read())
                    { 
                       if(PUBLIC_VARS.d.reader["status"].ToString() == rems){
                           propStatus = PUBLIC_VARS.d.reader["status"].ToString();
                           propMnt_amount = Convert.ToDouble(PUBLIC_VARS.d.reader["mnt_amount"].ToString());
                           propPrinc = Convert.ToDouble(PUBLIC_VARS.d.reader["principal"].ToString());
                           propHpenalty = Convert.ToDouble(PUBLIC_VARS.d.reader["penalty_amount"].ToString());
                           break;
                       }
                       propMnt_amount = Convert.ToDouble( PUBLIC_VARS.d.reader["mnt_amount"].ToString());
                       propPrinc =Convert.ToDouble( PUBLIC_VARS.d.reader["principal"].ToString());
                       propHpenalty = Convert.ToDouble(PUBLIC_VARS.d.reader["penalty_amount"].ToString());
                    }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }


        public void UPDATE_LENDER_INFORM(int m_ID)
        {
            sql = "";
            sql = "update tschedule_of_payment SET loan_id = " + this.propLoan_id + "," +
                  "tmoneylender_loan = " + this.propMoneyLender_id + ",status = '" + this.propStatus + "'," +
                  " mnt_amount = " + this.propMnt_amount + " where moneylender_loan_ID = " + m_ID;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public bool HAS_ACTIVELOAN(int lender_id)
        {
            bool jhun = false;
            sql = "";
            sql = "select * from tschedule_of_payment where  moneylender_id = " + lender_id;
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
        
        public bool PEND_ACTIVELOAN(int lender_id)
        {
           // bool jhun = false;
            sql = "";
            sql = "select * from tmoneylender_loan where  cust_id = " + lender_id;
            PUBLIC_VARS.d.execute(sql);
            Int32 cntr =0;
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {

                    while (PUBLIC_VARS.d.reader.Read())
                    {

                        cntr = cntr + 1;
                    }
                }

                if (cntr >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                PUBLIC_VARS.d.reader.Close();
            }
        }
        public void hasBorrowerPenalty(Int32 lenderID) {
            sql = "";

            //sql = "SELECT if((DATEDIFF(now(),sp.schedule_date) * p.penalty_amount) > 0,(DATEDIFF(now(),sp.schedule_date) * p.penalty_amount), 0) as penalties, " +
            //       "sp.moneylender_loan_ID from  tschedule_of_payment sp, tpenalty p " +
            //       " WHERE sp.STATUS = 'PENDING' and p.remarks = 'Active' and sp.moneylender_id = " + lenderID + " " +
            //       "group by sp.moneylender_loan_id" ;

            sql = "SELECT  if(DATEDIFF(now(),sp.schedule_date) >0,(sp.balance_amount * 0.015)/(30 * DATEDIFF(now(),sp.schedule_date)),0) as penalty, sp.moneylender_loan_ID" +
                  " from tschedule_of_payment sp WHERE sp.STATUS = 'PENDING' and sp.moneylender_id = 24 " +
                  " group by sp.moneylender_loan_id";

            PUBLIC_VARS.d.execute(sql);
           

            try
            {
               // List<double> lstq = new List<double>();
                if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                        string sql2 = "";
                        double dd = 0d;
                        // int index = lsv.Items.Count;

                        dd = Convert.ToDouble(PUBLIC_VARS.d.reader["penalty"].ToString());
                        Int32 mid = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_loan_id"].ToString());
                        PUBLIC_VARS.d.reader.Close();
                        sql2 = "UPDATE tschedule_of_payment SET penalty_amount = " + dd + " where moneylender_loan_id = " + mid;
                        PUBLIC_VARS.d.execute(sql2);
                        //PUBLIC_VARS.d.reader.Close();         
                        // lstq.Add(Convert.ToDouble(PUBLIC_VARS.d.reader["penalties"].ToString()));

                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            PUBLIC_VARS.d.reader.Close();
        }

        public void loadDetailsBorrowers(ListView lsv, int lenderID)
        {
            string sql = "";
            sql = "select * from tschedule_of_payment where moneylender_id ="+ lenderID;
            PUBLIC_VARS.d.execute(sql);
            lsv.Items.Clear();
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while(PUBLIC_VARS.d.reader.Read()){
                        int index = lsv.Items.Count;
                        //moneylender_loan_ID, loan_id, moneylender_id, status, mnt_amount, principal, penalty_amount, schedule_date
                        lsv.Items.Add(PUBLIC_VARS.d.reader["schedule_date"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["mnt_amount"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["penalty_amount"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["status"].ToString());
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }
    }
}
