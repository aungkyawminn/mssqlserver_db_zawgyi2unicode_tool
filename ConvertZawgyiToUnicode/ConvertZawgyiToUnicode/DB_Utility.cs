using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.Data.Common;


namespace ConvertZawgyiToUnicode
{
    public class DB_Utility
    {
        private string sqlServerName = null;
        private string sqlDatabaseName = null;
        private string sqlUserID = null;
        private string sqlPassword = null;

        public SqlConnection con = null;
        public SqlTransaction _dbTran = null;

        public const int UNIQUE_ERROR = -1; //DUPLICATE ERROR

        public void databaseConnect(string sqlUserID, string sqlPassword, string sqlServerName, string sqlDatabaseName)
        {
            String str = "";
            try
            {
                

                str = "User ID=" + sqlUserID + ";Password=" + sqlPassword + "; Data Source=" + sqlServerName + "; Initial Catalog=" + sqlDatabaseName;
                con = new SqlConnection(str);
                con.Open();


            }
            catch (SqlException sqle)
            {
                System.Console.WriteLine(sqle.Message);

            }
        }


        public void databaseDisconnect()
        {
            con.Close();
        }
    }
}
