using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using loantracking.CLASSES;
using System.Windows.Forms;


namespace loantracking.CLASSES
{
    class cl_myCI : cl_moneylender
    {
        string sql = "";
        private int CI_id;
        public void INSERT_DATAs()
        {
            //ci_id, fname, lname, ci_address, ci_tel_no
            sql = "INSERT INTO TCI VALUES(NULL,'" + propfname + "','" + proplname + "'," +
                  "'" + propAddress + "','" + propContact_no + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void UPDATE_DATAs()
        {
            sql = "UPDATE TCI SET FNAME = '" + propfname + "', LNAME = '" + proplname + "',CI_ADDRESS = '" + propAddress + "'," +
                   "CI_TEL_NO = " + propContact_no + " WHERE CI_ID = " + propCI_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void DELETE_DATAs()
        {
            sql = "delete from tci WHERE CI_ID = " + propCI_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void LOAD_FIELDSs(int ci_id)
        {
            sql = "SELECT * FROM TCI WHERE CI_ID = " + ci_id;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        propCI_id = Convert.ToInt32(PUBLIC_VARS.d.reader["ci_id"].ToString());
                        propfname = PUBLIC_VARS.d.reader["fname"].ToString();
                        proplname = PUBLIC_VARS.d.reader["lname"].ToString();
                        propAddress = PUBLIC_VARS.d.reader["ci_address"].ToString();
                        propContact_no = PUBLIC_VARS.d.reader["ci_tel_no"].ToString();
                    }

                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public void LOAD_LISTs(ListView lsv)
        {
            lsv.Items.Clear();
            sql = "select * from tci";
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int i = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["ci_id"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["fname"].ToString() + " " + PUBLIC_VARS.d.reader["lname"].ToString());
                        //lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["lname"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["ci_address"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["ci_tel_no"].ToString());
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }


        public int propCI_id
        {
            get { return this.CI_id; }
            set { this.CI_id = value; }
        }

       
    }
}
