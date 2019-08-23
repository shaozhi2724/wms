using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace WMS.Windows.App
{
    static class DBManager
    {
        private static int _dbMajorVersion = 0;
        private static bool _isConnected = false;
        private static bool _isInitialized = false;
        private static string _efConnectionString;
        private static string _sqlConnectionString;

        #region Properties

        public static string EFConnectionString
        {
            get { return _efConnectionString; }
        }

        public static string SQLConnectionString
        {
            get { return _sqlConnectionString; }
        }

        public static int DBMajorVersion
        {
            get { return _dbMajorVersion; }
        }

        public static bool IsConnected
        {
            get { return _isConnected; }
        }

        public static bool IsInitialized
        {
            get { return _isInitialized; }
        }

        #endregion

        #region Constructor

        static DBManager()
        {
            _efConnectionString = GetEFConnectionString();
            _sqlConnectionString = GetSQLConnectionString();
        }

        #endregion

        #region Public Methods

        public static void Connect()
        {
            try
            {
                string returnValue = string.Empty;
                SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString);
                SqlCommand sqlCommand = new SqlCommand();

                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "select top 1 ConfigID from SYS_Configure";
                returnValue = sqlCommand.ExecuteScalar().ToString().Substring(0, 1);
                _dbMajorVersion = int.Parse(returnValue);

                sqlCommand.Dispose();

                sqlConnection.Close();
                sqlConnection.Dispose();

                _isConnected = true;
            }
            catch (SqlException ex)
            {
                throw new Exception("未能创建数据库连接。", ex);
            }
        }

        public static string GenerateEFConnectionString(string sqlConnectionString)
        {
            Dictionary<string, string> connectionParameters = new Dictionary<string, string>();

            string[] nameValuePairs = sqlConnectionString.Split(';');
            foreach (string nameValuePair in nameValuePairs)
                connectionParameters.Add(nameValuePair.Split('=')[0].ToUpper(), nameValuePair.Split('=')[1]);

            string dataSource = string.Empty;
            string initialCatalog = string.Empty;
            string integratedSecurity = string.Empty;
            string password = string.Empty;
            string userID = string.Empty;
            string connectTimeout = string.Empty;

            connectionParameters.TryGetValue("DATA SOURCE", out dataSource);
            connectionParameters.TryGetValue("INITIAL CATALOG", out initialCatalog);
            connectionParameters.TryGetValue("INTEGRATED SECURITY", out integratedSecurity);
            connectionParameters.TryGetValue("PASSWORD", out password);
            connectionParameters.TryGetValue("USER ID", out userID);
            connectionParameters.TryGetValue("CONNECT TIMEOUT", out connectTimeout);

            if (string.IsNullOrEmpty(connectTimeout))
                connectTimeout = "120";

            string providerConnectionString;
            if (integratedSecurity != null &&
                (integratedSecurity.ToUpper().Equals("SSPI") || integratedSecurity.ToUpper().Equals("TRUE")))
            {
                providerConnectionString =
                    new SqlConnectionStringBuilder
                    {
                        DataSource = dataSource,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity = true,
                        ConnectTimeout = Convert.ToInt32(connectTimeout),
                        MultipleActiveResultSets = true
                    }.ConnectionString;
            }
            else
            {
                providerConnectionString = new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = false, UserID = userID, Password = password, ConnectTimeout = Convert.ToInt32(connectTimeout), MultipleActiveResultSets = true }.ConnectionString;
            }

            return new EntityConnectionStringBuilder { Metadata = @"res://*/WMSContext.csdl|res://*/WMSContext.ssdl|res://*/WMSContext.msl", Provider = "System.Data.SqlClient", ProviderConnectionString = providerConnectionString }.ConnectionString;
        }

        public static string GenerateSQLConnectionString(string existingConnectionString)
        {
            Dictionary<string, string> connectionParameters = new Dictionary<string, string>();

            string[] nameValuePairs = existingConnectionString.Split(';');
            foreach (string nameValuePair in nameValuePairs)
            {
                connectionParameters.Add(nameValuePair.Split('=')[0].ToUpper(), nameValuePair.Split('=')[1]);
            }

            string dataSource = string.Empty;
            string initialCatalog = string.Empty;
            string integratedSecurity = string.Empty;
            string password = string.Empty;
            string userID = string.Empty;
            string connectTimeout = string.Empty;

            connectionParameters.TryGetValue("DATA SOURCE", out dataSource);
            connectionParameters.TryGetValue("INITIAL CATALOG", out initialCatalog);
            connectionParameters.TryGetValue("INTEGRATED SECURITY", out integratedSecurity);
            connectionParameters.TryGetValue("PASSWORD", out password);
            connectionParameters.TryGetValue("USER ID", out userID);
            connectionParameters.TryGetValue("CONNECT TIMEOUT", out connectTimeout);

            if (string.IsNullOrEmpty(connectTimeout))
            {
                connectTimeout = "120";
            }

            if (integratedSecurity != null &&
                (integratedSecurity.ToUpper().Equals("SSPI") || integratedSecurity.ToUpper().Equals("TRUE")))
            {
                return
                    new SqlConnectionStringBuilder
                    {
                        DataSource = dataSource,
                        InitialCatalog = initialCatalog,
                        IntegratedSecurity = true,
                        ConnectTimeout = Convert.ToInt32(connectTimeout),
                        MultipleActiveResultSets = true
                    }.ConnectionString;
            }
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = false, UserID = userID, Password = password, ConnectTimeout = Convert.ToInt32(connectTimeout), MultipleActiveResultSets = true }.ConnectionString;
        }

        public static string GenerateSQLConnectionString(string dataSource, string initialCatalog)
        {
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = true, ConnectTimeout = 120 }.ConnectionString;
        }

        public static string GenerateSQLConnectionString(string dataSource, string initialCatalog, string userID, string password)
        {
            return new SqlConnectionStringBuilder { DataSource = dataSource, InitialCatalog = initialCatalog, IntegratedSecurity = false, UserID = userID, Password = password, ConnectTimeout = 120 }.ConnectionString;
        }

        public static string GetEFConnectionString()
        {
            // Look for a connection string in the application configuration file
            foreach (ConnectionStringSettings connectionStringSetting in ConfigurationManager.ConnectionStrings)
            {
                if (connectionStringSetting.Name.Equals("WMSContext"))
                {
                    return connectionStringSetting.ConnectionString;
                }
            }

            return string.Empty;
        }

        public static string GetSQLConnectionString()
        {
            string sqlConnectionString = string.Empty;

            // Constants
            string registryKeyName = "SOFTWARE\\WMS Systems\\WMSWindowsApp";
            string registryKeyName64 = "SOFTWARE\\Wow6432Node\\WMS Systems\\WMSWindowsApp";
            string registryKeyValue = "DBConn";

            // 1 - Look for a connection string in the application configuration file
            foreach (ConnectionStringSettings connectionStringSetting in ConfigurationManager.ConnectionStrings)
            {
                if (connectionStringSetting.Name.Equals("DbConnectStrings"))
                {
                    sqlConnectionString = connectionStringSetting.ConnectionString;
                    break;
                }
            }

            // 2 - Look for a local connection string in the system registry
            if (string.IsNullOrEmpty(sqlConnectionString))
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(registryKeyName, false);

                // If a 32-bit Registry Key was not found, look for a 64-bit Registry Key
                if (registryKey == null)
                {
                    registryKey = Registry.LocalMachine.OpenSubKey(registryKeyName64, false);
                }

                // If the Registry Key was found, return it
                if (registryKey != null && registryKey.GetValue(registryKeyValue) != null)
                {
                    sqlConnectionString = registryKey.GetValue(registryKeyValue).ToString();
                }
            }

            // 3 - Regenerate the connection string to override the OLE DB Provider settings
            if (sqlConnectionString.ToUpper().Contains("PROVIDER=SQLOLEDB"))
            {
                sqlConnectionString = GenerateSQLConnectionString(sqlConnectionString);
            }

            return sqlConnectionString;
        }

        public static DataTable GetData(string sqlStatement)
        {
            return GetData(sqlStatement, -1);
        }

        public static DataTable GetData(string sqlStatement, int commandTimeout)
        {
            SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);

            if (commandTimeout >= 0)
            {
                sqlDataAdapter.SelectCommand.CommandTimeout = commandTimeout;
            }

            sqlConnection.Open();

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlDataAdapter.Dispose();

            sqlConnection.Close();
            sqlConnection.Dispose();

            return dataTable;
        }

        public static void WriteEFConnectionString(string connectionString)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Create a new connection string entry and add it to the connectionStrings section (remove any existing string first)
            ConnectionStringSettings efConnectionString = new ConnectionStringSettings("WMSContext", connectionString, "System.Data.EntityClient");
            if (config.ConnectionStrings.ConnectionStrings["WMSContext"] != null)
            {
                config.ConnectionStrings.ConnectionStrings.Remove("WMSContext");
            }
            config.ConnectionStrings.ConnectionStrings.Add(efConnectionString);

            // Save the configuration file and refresh the section
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void WriteSQLConnectionString(string connectionString)
        {
            // Open the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Create a new connection string entry and add it to the connectionStrings section (remove any existing string first)
            ConnectionStringSettings efConnectionString = new ConnectionStringSettings("DbConnectStrings", connectionString, "System.Data.SqlClient");
            if (config.ConnectionStrings.ConnectionStrings["DbConnectStrings"] != null)
            {
                config.ConnectionStrings.ConnectionStrings.Remove("DbConnectStrings");
            }
            config.ConnectionStrings.ConnectionStrings.Add(efConnectionString);

            // Save the configuration file and refresh the section
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        #endregion

        #region Private Methods

        private static int ExecuteSQL(string sqlStatement)
        {
            return ExecuteSQL(sqlStatement, -1);
        }

        private static int ExecuteSQL(string sqlStatement, int commandTimeout)
        {
            if (sqlStatement.Trim().Length > 0)
            {
                SqlConnection sqlConnection = new SqlConnection(_sqlConnectionString);
                SqlCommand sqlCommand = new SqlCommand(sqlStatement.Trim(), sqlConnection);

                if (commandTimeout >= 0)
                {
                    sqlCommand.CommandTimeout = commandTimeout;
                }

                sqlConnection.Open();

                int recordsUpdated = sqlCommand.ExecuteNonQuery();

                sqlCommand.Dispose();

                sqlConnection.Close();
                sqlConnection.Dispose();

                return recordsUpdated;
            }
            return -1;
        }

        #endregion
    }
}
