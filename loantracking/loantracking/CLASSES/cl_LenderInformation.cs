using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using loantracking.CLASSES;
using loantracking.FORMS;

namespace loantracking.CLASSES 
{
     class cl_LenderInformation : cl_moneylender
    {
        private string birhtplace;
        private string civilstatus;
        private DateTime dob;
        private string email;
        private string gender;
        private string tin_no;
        private string housetype;
        private string occupation;
        private string company_add;
        private int length_of_service;
        private int monenylenderInfoID;
        private string position;
        private string company_name;
        string sql = "";
    
        public DateTime propDOB
        {
            get
            {
                return this.dob;
            }
            set
            {
                this.dob = value;
            }
        }

        public string propGender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public string propCivilStatus
        {
            get
            {
                return this.civilstatus;
            }
            set
            {
                this.civilstatus = value;
            }
        }

        public String propEmail
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string propbirthplace
        {
            get
            {
                return this.birhtplace;
            }
            set
            {
                this.birhtplace = value;
            }
        }

        public string propTIN_no
        {
            get
            {
                return this.tin_no;
            }
            set
            {
                this.tin_no = value;
            }
        }

        public string propHouseType
        {
            get
            {
                return this.housetype;
            }
            set
            {
                this.housetype = value;
            }
        }

        public string propOccupation
        {
            get
            {
                return this.occupation;
            }
            set
            {
                this.occupation = value;
            }
        }

        public string propPosition
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public string propCompanyName
        {
            get
            {
                return this.company_name;
            }
            set
            {
                this.company_name = value;
            }
        }

        public int propLengthofService
        {
            get
            {
                return length_of_service;
            }
            set
            {
                this.length_of_service = value;
            }
        }

        public int propmonenylenderInfoID
        {
            get
            {
                return this.monenylenderInfoID;
            }
            set
            {
                this.monenylenderInfoID = value;
            }
        }

        public string propCompanyAdd
        {
            get
            {
                return company_add;
            }
            set
            {
                this.company_add = value;
            }
        }
    
        public void INSERT_DATATOLENDER()
        {  //tmoneylender_information
            //moneylender_info_id, moneylender_id, dateofbirth, birthplace, gender, civil_status,
            //email_add, TIN_NO, HOUSE_TYPE, occupation, position, company_name, comp_add, length_of_service
            sql = "";
            sql = "INSERT INTO tmoneylender_information VALUES (NULL, " + this.propMoneyLender_id + ", '" + this.propDOB.Date.ToString("yyyy-MM-dd HH:mm") + "'," +
                " '" + this.propbirthplace + "', '" + this.propGender + "', '" + this.propCivilStatus + "', '" + this.propEmail + "', '" + this.propTIN_no + "', " +
                " '" + this.propHouseType + "', '" + this.propOccupation + "', '" + this.propPosition + "', '" + propCompanyName + "', '" + this.propCompanyAdd + "'," +
                " " + this.propLengthofService + ")";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void UPDATE_DATATOLENDER()
        {
            throw new System.NotImplementedException();
        }

        public void DELETE_DATATOLENDER()
        {
            throw new System.NotImplementedException();
        }

        public void LOAD_TOLIST(int moneylender_ID)
        {//tmoneylender_information
            //moneylender_info_id, moneylender_id, dateofbirth, birthplace, gender, civil_status,
            //email_add, TIN_NO, HOUSE_TYPE, occupation, position, company_name, comp_add, length_of_service
            sql = "";
            sql = "SELECT * FROM  tmoneylender_information where moneylender_id = " + moneylender_ID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                         propmonenylenderInfoID = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_info_id"].ToString());
                         propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                         //propbirthplace = 
                    }
                
                }

            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally {PUBLIC_VARS.d.reader.Close();}
       
        }

        public void LOAD_TOFIELDS()
        {
            throw new System.NotImplementedException();
        }
    }
}
