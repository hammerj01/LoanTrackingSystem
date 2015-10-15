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

        public void InsertUserId(string username, string password,string utype) {
            string sql = "INSERT into tuser values(null,'" + username + "','" + password + "','" + utype + "')";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }
        public void UpdateUser(string username, string password, string utype, int uids)
        {
            string sql = "UPDATE tuser set username='" + username + "',password='" + password + "',utype='" + utype + "'" +
                " where user_id=" + uids + "";
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
                this.username = PUBLIC_VARS.d.reader.GetString("username").ToString();
                this.password = PUBLIC_VARS.d.reader.GetString("password").ToString();
                this.utype =   PUBLIC_VARS.d.reader.GetString("utype");
            }
            PUBLIC_VARS.d.reader.Close();
        }

        public void loaduserToListview(ListView lsv, int uIDs) {
            string sql = "";

            if (uIDs > 0)
            {
                sql = "SELECT * FROM tuser wehre user_id = "+ uIDs;     
            }
            else {
                sql = "SELECT * from tuser";
            }
            PUBLIC_VARS.d.execute(sql);
            try
            {
                //user_id, username, password, utype
                lsv.Items.Clear();
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int i = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["user_id"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["username"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["password"].ToString());
                        lsv.Items[i].SubItems.Add(PUBLIC_VARS.d.reader["utype"].ToString());
                  //      lsv.Items[i].SubItems[3].ForeColor. = green;   //  PUBLIC_VARS.d.reader[3].GetType
                        //expenseItem.Font = new System.Drawing.Font(         "Arial", 10, System.Drawing.FontStyle.Italic);
                        //lsv.Items[i].SubItems["password"].Font = new System.Drawing.Font("Arial", 10);

                       
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }
    }
}
