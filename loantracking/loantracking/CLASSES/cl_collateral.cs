using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using loantracking.CLASSES;
using System.Windows.Forms;

namespace loantracking
{
    public class cl_collateral
    {
        private int collateral_id;
        private string collateral_name;
        private string collateral_description;
    
        public int propCollateral_id
        {
            get
            {
                return this.collateral_id;
            }
            set
            {
                this.collateral_id = value;
            }
        }

        public string propCollateral_name
        {
            get
            {
                return this.collateral_name;
            }
            set
            {
                this.collateral_name = value;
            }
        }

        public string propCollateral_description
        {
            get
            {
                return this.collateral_description;
            }
            set
            {
                this.collateral_description = value;
            }
        }
    
        public void INSERT_DATA()
        {
            string sql = "";
            sql = "INSERT INTO tcollateral VALUES(NULL,'" + propCollateral_name + "'," +
                   "'" + propCollateral_description + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
            
        }

        public void UPDATA_DATA()
        {
            //collateral_id, collateral_name, description
            string sql = "";
            sql = "UPDATE tcollateral set collateral_name = '" + propCollateral_name + "'," +
                  "collateral_description = '" + propCollateral_description + "' WHERE collateral_id = " + propCollateral_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void DELETE_DATA()
        {
            string sql = "";
            sql = "DELETE FROM tcollateral WHERE collateral_id = " + propCollateral_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void LOAD_FIELDS(int collateral_id)
        {  //collateral_id, collateral_name, description
            string sql = "";
            sql = "SELECT * FROM tcollateral WHERE collateral_id = " + collateral_id;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows) { 
                    while(PUBLIC_VARS.d.reader.Read()){
                        propCollateral_id = Convert.ToInt32(PUBLIC_VARS.d.reader["collateral_id"].ToString());
                        propCollateral_name = PUBLIC_VARS.d.reader["collateral_name"].ToString();
                        propCollateral_description = PUBLIC_VARS.d.reader["collateral_description"].ToString();
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public void LOAD_LSV(ListView lsv)
        {
            lsv.Items.Clear();
             string sql1 = "";
             sql1 = "SELECT * FROM tcollateral";
             PUBLIC_VARS.d.execute(sql1);
             try
             {
                 if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                         int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["collateral_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["collateral_name"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["collateral_description"].ToString());
                    }
                 }
             }
             catch (Exception ex) { MessageBox.Show(ex.Message); }
             finally { PUBLIC_VARS.d.reader.Close(); }
        }
    }
}
