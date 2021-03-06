﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace loantracking.CLASSES
{
    class cl_moneylender
    {
        private int moneylender_id;
        public string fname;
        public string lname;
        public string mi;
        public string address;
        private int age;
        private double credit_limit;
        private DateTime date_moneylender;
        public string contact_no;
        private string lenderID;
        private string picBarrower;
        private string is_inactive;


        public string propIs_inactive {
            get { return this.is_inactive; }
            set { this.is_inactive = value; }
        }
        public string propPicBarrower {
            get { return this.picBarrower; }
            set { this.picBarrower = value; }
        }

        public string propAddress
        {
            get
            {
                return this.address;
            }
            set
            {this.address = value;
            }
        }

        public int propAge
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string propfname
        {
            get
            {
                return this.fname;
            }
            set
            {
                this.fname = value;
            }
        }

        public string proplname
        {
            get
            {
                return this.lname;
            }
            set
            {
                this.lname = value;
            }
        }

        public string propMI
        {
            get
            {
                return this.mi;
            }
            set
            {
                this.mi = value;
            }
        }

        public int propMoneyLender_id
        {
            get
            {
                return this.moneylender_id;
            }
            set
            {
                this.moneylender_id = value;
            }
        }

        public double propCreditLimit
        {
            get
            {
                return this.credit_limit;
            }
            set
            {
                this.credit_limit = value;
            }
        }
    public DateTime propDate{
        get {return this.date_moneylender; }
        set {this.date_moneylender = value;}
    }

    public string propContact_no
    {
        get
        {
            return this.contact_no;
        }
        set
        {
            this.contact_no = value;
        }
    }

    public string propLenderID
    {
        get
        {
            return this.lenderID;
        }
        set
        {
            this.lenderID = value;
        }
    }

    
        public void INSERT_DATA()
        {
            string sql = "";
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit
            sql = "INSERT INTO tmoneylender VALUES(NULL," +
                  "'" + propfname + "','" + proplname + "','" + propMI + "',"  +
                  "'" + propAddress + "', " + propAge + ", NOW(), " + propCreditLimit + ", '" + propContact_no +"'," +
                  "'" + propLenderID + "','" + propIs_inactive + "')";
             PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void UPDATE_DATA(int moneylender_id)
        {
            string sql = "";
            sql = "UPDATE tmoneylender SET address = '" + propAddress + "'," +
                  " FNAME = '" + propfname + "', lname = '" + proplname + "', " + 
                  " mi = '" + propMI + "', age = " + propAge + ",  credit_limit = " + propCreditLimit + ", " +
                  " contact_no = '" + propContact_no + "', lenderID = '" + propLenderID + "', is_active = '" + this.propIs_inactive + "' " +
                  " WHERE moneylender_id = " + moneylender_id;
                PUBLIC_VARS.d.execute(sql);
                PUBLIC_VARS.d.reader.Close();
        }
        public void DELETE_DATA(int moneylender_id) {
            string sql = "";
            sql = "delete from tmoneylender where moneylender_id = " + moneylender_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void LOAD_MONEYLENDER(ListView lsv)
        {
            lsv.Items.Clear();
            string sql = "";
            sql = "SELECT * FROM tmoneylender";
            PUBLIC_VARS.d.execute(sql);
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit, contact_no, lenderID, is_active
            try {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["lenderID"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["fname"].ToString() + " " + PUBLIC_VARS.d.reader["mi"].ToString() + " " + PUBLIC_VARS.d.reader["lname"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["address"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["age"].ToString());
                        
                        //MessageBox.Show(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["credit_limit"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["contact_no"].ToString());
                        lsv.Items[index].SubItems.Add(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["is_active"].ToString());
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            finally{
                PUBLIC_VARS.d.reader.Close();
            }
        }

        public void LOAD_MONEYLENDER_Actvie(ListView lsv,string txt)
        {
            lsv.Items.Clear();
            string sql = "";

            if(txt == "Active"){
                sql = "SELECT * FROM tmoneylender where is_active ='" + txt + "'";
            }
            else if (txt == "Inactive")
            {
                sql = "SELECT * FROM tmoneylender where is_active ='" + txt + "'";  
            }
            else if (txt == "All")
            {
                sql = "SELECT * FROM tmoneylender";
            }
            
            
            PUBLIC_VARS.d.execute(sql);
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit, contact_no, lenderID, is_active
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["lenderID"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["fname"].ToString() + " " + PUBLIC_VARS.d.reader["mi"].ToString() + " " + PUBLIC_VARS.d.reader["lname"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["address"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["age"].ToString());

                        //MessageBox.Show(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["credit_limit"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["contact_no"].ToString());
                        lsv.Items[index].SubItems.Add(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["is_active"].ToString());
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

        public void LOADTOFIELDS(int MLT_ID)
        {
            string sql = "";

            sql = "SELECT * FROM tmoneylender WHERE  moneylender_id = " + MLT_ID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit
                if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                        propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        propfname = PUBLIC_VARS.d.reader["fname"].ToString();
                        proplname = PUBLIC_VARS.d.reader["lname"].ToString();
                        propMI = PUBLIC_VARS.d.reader["mi"].ToString();
                        propAddress = PUBLIC_VARS.d.reader["address"].ToString();
                        propAge =  Convert.ToInt32(PUBLIC_VARS.d.reader["age"].ToString());
                        //propDate =  Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString();
                        propCreditLimit =Convert.ToDouble(PUBLIC_VARS.d.reader["credit_limit"].ToString());
                        
                        propContact_no = PUBLIC_VARS.d.reader["contact_no"].ToString();
                        propLenderID = PUBLIC_VARS.d.reader["lenderID"].ToString();
                        propIs_inactive = PUBLIC_VARS.d.reader["is_active"].ToString();
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }


        public void LOADTOFIELDSLenderID(string MLT_ID)
        {
            string sql = "";

            sql = "SELECT * FROM tmoneylender WHERE  lenderID = '" + MLT_ID + "'";
            PUBLIC_VARS.d.execute(sql);
            try
            {
                //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        propfname = PUBLIC_VARS.d.reader["fname"].ToString();
                        proplname = PUBLIC_VARS.d.reader["lname"].ToString();
                        propMI = PUBLIC_VARS.d.reader["mi"].ToString();
                        propAddress = PUBLIC_VARS.d.reader["address"].ToString();
                        propAge = Convert.ToInt32(PUBLIC_VARS.d.reader["age"].ToString());
                        //propDate =  Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString();
                        propCreditLimit = Convert.ToDouble(PUBLIC_VARS.d.reader["credit_limit"].ToString());
                        propContact_no = PUBLIC_VARS.d.reader["contact_no"].ToString();
                        propLenderID = PUBLIC_VARS.d.reader["lenderID"].ToString();
                        propLenderID = PUBLIC_VARS.d.reader["is_active"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public void SearchLenderByName(string txt, ListView lsv) {
            lsv.Items.Clear();
            string sql = "";
            sql = "SELECT * FROM tmoneylender where lname like '%" + txt + "%'";
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if(PUBLIC_VARS.d.reader.HasRows){
                    while(PUBLIC_VARS.d.reader.Read()){
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["fname"].ToString() + " " + PUBLIC_VARS.d.reader["mi"].ToString() + " " + PUBLIC_VARS.d.reader["lname"].ToString());
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
      
        }

        public void Search_MONEYLENDER(ListView lsv,string txt)
        {
            lsv.Items.Clear();
            string sql = "";

            //if (txt == "view"){
            //    sql = "SELECT * FROM tmoneylender";
            //}
            //else
             sql = "SELECT * FROM tmoneylender WHERE lname like '%" + txt + "%'"; 
            
           
            PUBLIC_VARS.d.execute(sql);
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    while (PUBLIC_VARS.d.reader.Read())
                    {
                        int index = lsv.Items.Count;
                        lsv.Items.Add(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["lenderID"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["fname"].ToString() + " " + PUBLIC_VARS.d.reader["mi"].ToString() + " " + PUBLIC_VARS.d.reader["lname"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["address"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["age"].ToString());

                        //MessageBox.Show(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["credit_limit"].ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["contact_no"].ToString());
                        lsv.Items[index].SubItems.Add(Convert.ToDateTime(PUBLIC_VARS.d.reader["date_lender"].ToString()).ToShortDateString().ToString());
                        lsv.Items[index].SubItems.Add(PUBLIC_VARS.d.reader["is_active"].ToString());
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

        public void InserPictureBarrower() {
            string sql = "";
            //idtbarrowerpicture, barrower_path, moneylender_id
            sql = "insert into tbarrowerpicture values(null,'" + this.propPicBarrower + "'," + this.propMoneyLender_id + ")";
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void UpdatePicBarrower() {
            string sql = "";
            sql = "update tbarrowerpicture SET barrower_path = '" + this.propPicBarrower + "' where moneylender_id =" + this.propMoneyLender_id;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        }

        public void loadPictureBarrower(Int32 mID) {
            string sql = "";
            sql = "SELECT * FROM tbarrowerpicture where moneylender_id =" + mID;
            PUBLIC_VARS.d.execute(sql);
            try
            {
                if (PUBLIC_VARS.d.reader.HasRows)
                {
                    PUBLIC_VARS.d.reader.Read();
                    this.propMoneyLender_id = Convert.ToInt32(PUBLIC_VARS.d.reader["moneylender_id"].ToString());
                    this.propPicBarrower = PUBLIC_VARS.d.reader["barrower_path"].ToString();
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { PUBLIC_VARS.d.reader.Close(); }
        }

        public bool isBarrowerExist() {
            string sql = "";
            bool ham = false;
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit, contact_no, lenderID
            sql = "select * from tmoneylender where lname = '" + this.proplname + "' and fname = '" + this.propfname + "'";
            PUBLIC_VARS.d.execute(sql);
           
                if(PUBLIC_VARS.d.reader.HasRows){
                    PUBLIC_VARS.d.reader.Read();
                    
                    ham = true;

                }
                 PUBLIC_VARS.d.reader.Close();
                if (ham == true)
                {
                    return true;
                }
                else {
                    return false;
                }
                 
        }

        public bool isBarrowerActive(int myIDs)
        {
            string sql = "";
            bool ham = false;
            //moneylender_id, fname, lname, mi, address, age, date_lender, credit_limit, contact_no, lenderID
            sql = "select * from tmoneylender where moneylender_id = " + myIDs;
            PUBLIC_VARS.d.execute(sql);

            if (PUBLIC_VARS.d.reader.HasRows)
            {
                PUBLIC_VARS.d.reader.Read();

                if (PUBLIC_VARS.d.reader["is_active"].ToString() == "Inactive")
                {
                    ham = true;
                }
                else { ham = false; }

            }
            PUBLIC_VARS.d.reader.Close();
            if (ham == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
