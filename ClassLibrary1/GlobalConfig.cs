using System;
using System.Collections.Generic;
using System.Text;
using DataLibrary.DataAccess;
using System.Configuration;

namespace DataLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connections=sql;
        }


        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
