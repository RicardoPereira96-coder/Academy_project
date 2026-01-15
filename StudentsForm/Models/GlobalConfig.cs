using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    /// <summary>
    /// Static class that holds the global configuration and the active data connection for the app.
    /// This allows any form to access the data layer via GlobalConfig.Connection.
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// The active data connection (SQL or TextFile). 
        /// It is protected by a private set so it can only be changed within this class.
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Sets up the data connection based on the selected Database Type.
        /// This is usually called once when the application starts (Program.cs).
        /// </summary>
       
        public static void InitializeConnections(DataBaseType db)
        {
            if (db == DataBaseType.Sql)
            {
                // Implement SqlConnector class logic
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DataBaseType.TextFile)
            {
                // Implemtent TextConnector class logic
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        /// <summary>
        /// Retrieves a connection string from the App.config file.
        /// </summary>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
