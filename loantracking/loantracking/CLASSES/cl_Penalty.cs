using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using loantracking.CLASSES;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_Penalty
    {
        //tpenalty
        //penalty_id, penalty_amount, remarks
        private int penalty_id;
        private double penalty_amount;
        private string remarks;
       private string SQL = "";

        public int propPenalty_Id {
            get { return this.penalty_id; }
            set { this.penalty_id = value; }
        }
        public double propPenalty_amount { 
            get { return this.penalty_amount; }
            set { this.penalty_amount = value; }
        }
        public string propPenalty_remarks { 
            get { return this.remarks; }
            set { this.remarks = value; }
        }

        public void INSERT_PENALTY() { 
            SQL ="";
            SQL = "INSERT INTO TPENALTY VALUES(null,"+ this.propPenalty_amount+ ",'" + this.propPenalty_remarks + "')";
            PUBLIC_VARS.d.execute(SQL);
            PUBLIC_VARS.d.reader.Close();
        }
        public void update_penalty() {
            SQL = "";
            //tpenalty
            //penalty_id, penalty_amount, remarks
            SQL = "update tpenalty SET penalty_amount = " + this.propPenalty_amount + ",remarks = '" + this.propPenalty_remarks + "' where penalty_id = " + this.propPenalty_Id;
            PUBLIC_VARS.d.execute(SQL);
            PUBLIC_VARS.d.reader.Close();

        }
        public void delete_penalty() {
            SQL = "";
            SQL = "delete from tpenalty where penalty_id = " + this.propPenalty_Id;
            PUBLIC_VARS.d.execute(SQL);
            PUBLIC_VARS.d.reader.Close();
        }
        public void loadFieldToPenalty(int penalty_id) {
            SQL = "";
            SQL = "SELECT * FROM tpenalty where penalty_id = "+ penalty_id;
            PUBLIC_VARS.d.execute(SQL);
            try {
                //tpenalty
                //penalty_id, penalty_amount, remarks
                if (PUBLIC_VARS.d.reader.HasRows) {
                    PUBLIC_VARS.d.reader.Read();
                    this.propPenalty_Id = Convert.ToInt32(PUBLIC_VARS.d.reader["penalty_id"].ToString());
                    this.propPenalty_amount = Convert.ToDouble(PUBLIC_VARS.d.reader["penalty_amount"].ToString());
                    this.propPenalty_remarks = PUBLIC_VARS.d.reader["remarks"].ToString();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        
        }

        public void loadListviewToPenalty(ListView lsv, int penalty_id)
        {
            SQL = "";
            SQL = "SELEECT * FROM tpenalty where penalty_id =" + penalty_id;
            PUBLIC_VARS.d.execute(SQL);
            lsv.Items.Clear();
            try
            {
                //tpenalty
                //penalty_id, penalty_amount, remarks
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["penalty_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["penalty_amount"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["remarks"].ToString());
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }

        }
        public bool countActive(string hasActive) {
            string SQL = "";
            SQL = "select * from tpenalty where remarks ='" + hasActive + "'";
            bool ler = false;
            PUBLIC_VARS.d.execute(SQL);
          
                int index = 0 ;
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    
    
                    while (PUBLIC_VARS.d.reader.Read())
                    {


                        if (PUBLIC_VARS.d.reader["remarks"].ToString() == "Active")
                        {
                            index = index + 1;
                            //ler = true;
                        }
                      
                    }
                    
                }
                PUBLIC_VARS.d.reader.Close();
                if (index >0)
                {
                    ler = true;
                   return ler;
                }
                else
                {
                    ler = false;
                    return ler;
                }
            }


        
    }
}
