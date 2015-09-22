using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loantracking.CLASSES
{
    class PUBLIC_VARS
    {
        //public static List<Item> item_col = new List<Item>();
        //public static List<Stockin> stockin_col = new List<Stockin>();
        public static db d = new db();
        public static bool EDITMODE;
        public static int activeID = 0;
        //public static int activeUser;

        public static string saveData = "Record has been successfully save.";
        public static string updateData = "Record has been successfully updated.";
        public static string deleteData = "Record has been successfully deleted.";

    }
}
