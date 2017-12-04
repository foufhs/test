using System;
using System.Collections.Generic;
using System.Text;
using DataLibrary.DataAccess;
using System.Configuration;

namespace DataLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }


        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
