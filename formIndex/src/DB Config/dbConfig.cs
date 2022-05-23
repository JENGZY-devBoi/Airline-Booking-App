using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace formIndex {
    static class dbConfig {
        static private string server = "DESKTOP-15449HT\\KMUTNBMC";
        //static private string server = "WIN-HKB7QARTSJ1\\KMUTNBMC";
        static private string database = "airbooking";
        static private string userID = "user1";
        static private string password = "mypass1";

        static private String cnn =
            $"server={server};" +
            $"database={database};" +
            $"user id={userID};" +
            $"password={password}";

        static public SqlConnection connection =
            new SqlConnection(cnn);
    }
}
