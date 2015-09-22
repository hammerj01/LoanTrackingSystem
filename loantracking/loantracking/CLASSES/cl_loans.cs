using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_loans
    {
        private int loan_id;
        private string loan_type;
        private string loan_desc;
    
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

        public string propLoan_type
        {
            get
            {
                return this.loan_type;
            }
            set
            {
                this.loan_type = value;
            }
        }

        public string propLoand_desc
        {
            get
            {
                return this.loan_desc;
            }
            set
            {
                this.loan_desc = value;
            }
        }
    
        public void INSERT_DATA()
        {
            //loan_id, loan_type, loan_description
            string sql = "INSERT INTO tloan values(NULL,'" + propLoan_type + "','" + propLoand_desc  + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void LOAD_FIELDS(int loan_id)
        {
           string sql = "SELECT * FROM tloan where loan_id = " + loan_id;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows) { 
                    while(PUBLIC_VARS.d.reader.Read()){
                        propLoan_id = Convert.ToInt32(PUBLIC_VARS.d.reader["loan_id"].ToString());
                        propLoan_type = PUBLIC_VARS.d.reader["loan_type"].ToString();
                        propLoand_desc = PUBLIC_VARS.d.reader["loan_description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                PUBLIC_VARS.d.reader.Close();
            }
        }
        public void LOADAllFields(ListView lsv)
        {
            lsv.Items.Clear();

            string sql = "SELECT * FROM tloan";
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["loan_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["loan_type"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["loan_description"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                PUBLIC_VARS.d.reader.Close();
            }
        }

        public void UPDATE_DATA()
        {
            string sql = "";
            sql = "UPDATE tloan SET LOAn_type ='" + propLoan_type + "', loan_description = '" + propLoand_desc + "' WHERE loan_id = " + propLoan_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public void DELETE_DATA(int loan_id) {
            string sql = "";
            sql = "DELETE FROM tloan WHERE loan_id = " + loan_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

    }
}
