using System;
using System.Collections.Generic;
using System.Text;

namespace WStock.Framework.Models
{
    public class ConnectionData
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public string getConnectionSqlServer()
        {
            return "Server=" + Server + "," + Port + ";Database=" + Database + ";Uid=" + User + ";Pwd=" + Password;
        }

        public string getConnectionMySql()
        {
            return "Database=" + Database + ";Data Source=" + Server + ";User Id=" + User + ";Password=" + Password;
        }

    }
}
