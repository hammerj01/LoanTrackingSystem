using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class db
    {
        public string _server = "";
        public string _user = "";
        public string _pw = "";
        public string _db = "";
        public MySqlDataReader reader;
        public MySqlConnection conn = new MySqlConnection();

        public bool connect()
        {
            string server_string;
            server_string = "server = " + this._server +
                          ";username = " + this._user +
                          ";password = " + this._pw +
                          ";database =" + this._db;
            this.conn.ConnectionString = server_string;

            try
            {
                conn.Open();
              //  MessageBox.Show("database connected");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public MySqlDataReader execute(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = this.conn;
                comm.CommandText = sql;
                this.reader = comm.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return this.reader;
        }


        public void executeNonReader(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = this.conn;
                comm.CommandText = sql;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

     
        public int getlastid()
        {
            string sql = " ";
            int id = 0;
            MySqlCommand comm = new MySqlCommand();
            sql = "SELECT last_insert_id()";
            comm.CommandText = sql;
            comm.Connection = this.conn;
            this.reader = this.execute(comm.CommandText);
            while (this.reader.Read())
            {
                id = reader.GetInt32(0);
            }
            this.reader.Close();
            return id;

        }
    }
}
