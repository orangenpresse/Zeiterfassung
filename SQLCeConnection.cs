using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using Zeiterfassung.Properties;

namespace Zeiterfassung
{
    class SQLCeConnection
    {
        private SqlCeConnection m_dbcon = new SqlCeConnection();

        public SqlCeDataReader query;

        public SQLCeConnection()
        {
            m_dbcon.ConnectionString = Settings.Default.ZeiterfassungConnectionString;
        }

        public SqlCeCommand SqlStatement(string SQLCommand)
        {
            SqlCeCommand cmd = new SqlCeCommand(SQLCommand, m_dbcon);
            return cmd;
        }

        public void Open()
        {
            m_dbcon.Open();
        }

        public void Close()
        {
            m_dbcon.Close();
        }
    }
}
