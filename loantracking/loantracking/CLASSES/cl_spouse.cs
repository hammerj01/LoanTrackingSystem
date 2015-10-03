using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using loantracking.CLASSES;

namespace loantracking
{
    class cl_spouse : cl_moneylender
    {
        private int spouseID;
        private string spouseName;
        private int spouse_age;
        private string spouse_company;
        private string spouse_Occupation;
        private DateTime spouse_dob;
        private string spouse_position;
        private string sql = "";
        public string propspousename
        {
            get
            {
                return this.spouseName;
            }
            set
            {
                this.spouseName = value;
            }
        }

        public DateTime propsDOB
        {
            get
            {
                return this.spouse_dob;
            }
            set
            {
                this.spouse_dob = value;
            }
        }

        public string propspouseOcc
        {
            get
            {
                return spouse_Occupation;
            }
            set
            {
                this.spouse_Occupation = value;
            }
        }

        public int props_age
        {
            get
            {
                return this.spouse_age;
            }
            set
            {
                this.spouse_age = value;
            }
        }

        public string propsCompany
        {
            get
            {
                return spouse_company;
            }
            set
            {
                this.spouse_company = value;
            }
        }

        public int propspouseID
        {
            get
            {
                return this.spouseID;
            }
            set
            {
                this.spouseID = value;
            }
        }
        public string propsPosition
        {
            get { return this.spouse_position; }
            set { this.spouse_position = value; }
        }
    
        public void INSERT_SPOUSE()
        {
            sql = "";
            //spouse_id, moneylender_id, spouse_name, s_age, dob, occupation, company, position
            //tspouse

            sql = "INSERT INTO tspouse VALUES(NULL, " + this.propMoneyLender_id + ", '" + this.propspousename + "', " + this.props_age + "," +
                  " '" + this.propsDOB + "','" + this.propspouseOcc + "', '" + this.propsCompany + "','" + this.propsPosition + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();

        }

        public void UPDATE_SPOUSE(int lenderID)
        {
            sql = "";
            sql = "UPDATE_LENDER_INFORM TSPOUSE SET spouse_name = '" + this.propspousename + "', s_age = " + this.props_age + "," +
                  " dob = '" + this.propsDOB + "', occupation = '" + this.propspouseOcc + "', company = '" + this.propsCompany + "'," +
                  " position = '" + this.propsPosition + "' WHERE moneylender_id = " + lenderID;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();

        }

        public void DELETE_SPOUSE()
        {
            sql = "";
            sql = "DELETE from tspouse where spouse_id = " + this.propspouseID;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void LOAD_TOLISTSPOUSE(int spouseID)
        {
            sql = "";
            sql = "SELECT * from tspouse where spouse_id = " + spouseID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows){
                    while (PUBLIC_VARS.d.reader.Read()){
                        //spouse_id, moneylender_id, spouse_name, s_age, dob, occupation, company, position
                        //tspouse

                        propspouseID = Convert.ToInt32(PUBLIC_VARS.d.reader["spouse_id"].ToString());
                        propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        propspousename = PUBLIC_VARS.d.reader["spouse_name"].ToString();
                        props_age = Convert.ToInt32(PUBLIC_VARS.d.reader["s_age"].ToString());
                        propsDOB = DateTime.Parse(PUBLIC_VARS.d.reader["dob"].ToString());
                    }
                
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public void LOAD_TOFIELDSPOUSE(int moneylender_ID)
        {
            sql = "";
            sql = "SELECT * from tspouse where moneylender_id = " + moneylender_ID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        //spouse_id, moneylender_id, spouse_name, s_age, dob, occupation, company, position
                        //tspouse

                        propspouseID = Convert.ToInt32(PUBLIC_VARS.d.reader["spouse_id"].ToString());
                        propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        propspousename = PUBLIC_VARS.d.reader["spouse_name"].ToString();
                        props_age = Convert.ToInt32(PUBLIC_VARS.d.reader["s_age"].ToString());
                        propsDOB = DateTime.Parse(PUBLIC_VARS.d.reader["dob"].ToString());
                        propsCompany = PUBLIC_VARS.d.reader["company"].ToString();
                            propspouseOcc = PUBLIC_VARS.d.reader["occupation"].ToString();
                            propsPosition = PUBLIC_VARS.d.reader["position"].ToString();
                    }

                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }
    }
}
