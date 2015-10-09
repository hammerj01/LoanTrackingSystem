using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loantracking.CLASSES
{
    class MYFUNCTIONS
    {
        //populate data in listview
        public void PopulateListView(ListView lsv, string sql)
        {
            ListViewItem lsv_item;
            PUBLIC_VARS.d.execute(sql);
            lsv.Items.Clear();
            if (PUBLIC_VARS.d.reader.HasRows)
            {
                while (PUBLIC_VARS.d.reader.Read())
                {
                    lsv_item = lsv.Items.Add(PUBLIC_VARS.d.reader.GetValue(0).ToString());
                    for (int x = 1; x <= PUBLIC_VARS.d.reader.FieldCount - 1; x++)
                    {
                        lsv_item.SubItems.Add(PUBLIC_VARS.d.reader.GetValue(x).ToString());
                    }
                }

            }
            PUBLIC_VARS.d.reader.Close();

        }

        //populate all data in combobox
        public void PopulateCombobox(ComboBox cbo, string sql)
        {
            cbo.Items.Clear();
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows)
            {
                while (PUBLIC_VARS.d.reader.Read())
                {
                    cbo.Items.Add(PUBLIC_VARS.d.reader.GetValue(1).ToString());
                }

            }
            PUBLIC_VARS.d.reader.Close();
        }

        public Int64 autoUserID() {
           Int64 strID =0;
           string sql = "select * from tcounter where counterNo = 1";
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows) {
                PUBLIC_VARS.d.reader.Read();
                strID = Convert.ToInt64(PUBLIC_VARS.d.reader["counterValue"].ToString());
               PUBLIC_VARS.d.reader.Close();
            }
            return strID;
            
        }
        public void InsertCounterNo(Int64 value) {
            string sql = "";
            sql = "UPDATE tcounter set counterValue = " + value;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        
        }

        public void acctPayable(ListView lsv, int dt, int yr) {
            string sql = "";

            if(dt <= 0 && yr<=0 ){
            sql = "SELECT b.lenderID,CONCAT(b.fname, ' ', b.mi, ' ' , b.lname) as NAME,b.address," +
                  " b.contact_no,sum(sp.mnt_amount) mnt_amount,sum(sp.penalty_amount) penalty_amount,sp.schedule_date " +
                  "from tmoneylender b " +
                  "inner join tschedule_of_payment sp on b.moneylender_id = sp.moneylender_id where status = 'pending' group by lenderID";
            }
            else{

            sql = "SELECT b.lenderID,CONCAT(b.fname, ' ', b.mi, ' ' , b.lname) as NAME,b.address," +
                  " b.contact_no,sp.mnt_amount,sp.penalty_amount,sp.schedule_date " +
                  "from tmoneylender b " +
                  "inner join tschedule_of_payment sp on b.moneylender_id = sp.moneylender_id " +
                  " where status = 'pending' and MONTH(sp.schedule_date) = " + dt + " and YEAR(sp.schedule_date) = " + yr ;
            }
            PUBLIC_VARS.d.execute(sql);
            try
            {
                //lenderID, NAME, address, contact_no, mnt_amount, penalty_amount, schedule_date
                lsv.Items.Clear();
                if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                        Int32 index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["lenderID"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["NAME"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["address"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["contact_no"].ToString());
                        lsv.Items[index].SubItems.Add(String.Format("{0:#,##0.00}",PUBLIC_VARS.d.reader["mnt_amount"].ToString()));
                        lsv.Items[index].SubItems.Add(String.Format("{0:#,##0.00}",PUBLIC_VARS.d.reader["penalty_amount"].ToString()));
                        lsv.Items[index].SubItems.Add(String.Format("{0:D}", (PUBLIC_VARS.d.reader["schedule_date"].ToString())));
                        
                    }
                
                }

            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

    }
}
