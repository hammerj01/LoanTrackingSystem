using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using loantracking.CLASSES;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_logIn
    {
        //user_id, username, password, utype
        //tuser
        public int uid;
        public string username,password, utype;

        public void InsertUserId() {
            string sql = "INSERT into tuser values(null,'" + this.username + "','" +
                this.password + "','" + this.utype + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public void UpdateUser() {
            string sql = "UPDATE_LENDER_INFORM tuser set username='" + this.username + "',password='"
                + this.password + "',utype='" + this.utype + "'" +
                " where user_id=" + this.uid + "";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public void DeleteUser(int id) {
            string sql = "Delete from tuser where user_id=" + id + ";";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public bool CheckUSer(string userID)
        {
            string sql = "SELECT * FROM tuser;";
            bool check = false;
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows)
            {
                while (PUBLIC_VARS.d.reader.Read())
                {
                    if (PUBLIC_VARS.d.reader.GetValue(1).ToString().Equals(userID))
                    {
                        check = true;
                        break;
                    }
                }

            }
            PUBLIC_VARS.d.reader.Close();
            if (check == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void loadUSer(int id) {
            string sql = "SELECT * from tuser where user_id=" + id + ";";
             //user_id, username, password, utype
        //tuser
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows) {
                PUBLIC_VARS.d.reader.Read();
                this.uid = Convert.ToInt32(PUBLIC_VARS.d.reader.GetString("user_id"));
                this.username = PUBLIC_VARS.d.reader.GetString("user_name").ToString();
                this.password = PUBLIC_VARS.d.reader.GetString("password").ToString();
      
                this.utype =   PUBLIC_VARS.d.reader.GetString("user_type");
            }
            PUBLIC_VARS.d.reader.Close();
        }
    }
}
