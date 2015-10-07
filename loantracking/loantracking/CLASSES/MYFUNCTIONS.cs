﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loantracking.CLASSES
{
    class MYFUNCTIONS
    {
        //populate data in listview
        public void PopulateListView(ListView lsv, string sql)
        {
            ListViewItem lsv_item;
            PUBLIC_VARS.d.execute(sql);
            lsv.Items.Clear();
            if (PUBLIC_VARS.d.reader.HasRows)
            {
                while (PUBLIC_VARS.d.reader.Read())
                {
                    lsv_item = lsv.Items.Add(PUBLIC_VARS.d.reader.GetValue(0).ToString());
                    for (int x = 1; x <= PUBLIC_VARS.d.reader.FieldCount - 1; x++)
                    {
                        lsv_item.SubItems.Add(PUBLIC_VARS.d.reader.GetValue(x).ToString());
                    }
                }

            }
            PUBLIC_VARS.d.reader.Close();

        }

        //populate all data in combobox
        public void PopulateCombobox(ComboBox cbo, string sql)
        {
            cbo.Items.Clear();
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows)
            {
                while (PUBLIC_VARS.d.reader.Read())
                {
                    cbo.Items.Add(PUBLIC_VARS.d.reader.GetValue(1).ToString());
                }

            }
            PUBLIC_VARS.d.reader.Close();
        }

        public Int64 autoUserID() {
           Int64 strID =0;
           string sql = "select * from tcounter where counterNo = 1";
            PUBLIC_VARS.d.execute(sql);
            if (PUBLIC_VARS.d.reader.HasRows) {
                PUBLIC_VARS.d.reader.Read();
                strID = Convert.ToInt64(PUBLIC_VARS.d.reader["counterValue"].ToString());
               PUBLIC_VARS.d.reader.Close();
            }
            return strID;
            
        }
        public void InsertCounterNo(Int64 value) {
            string sql = "";
            sql = "UPDATE tcounter set counterValue = " + value;
            PUBLIC_VARS.d.execute(sql);
            PUBLIC_VARS.d.reader.Close();
        
        }     

    }
}
