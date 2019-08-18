using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertZawgyiToUnicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                convertFont();
            }
            catch(Exception eee)
            {
                MessageBox.Show(eee.Message + "Try Again");
                error.Visible = true;
            }

        }

        private void convertFont()
        {

            string svr = server.Text;
            string usr = username.Text;
            string pwd = password.Text;
            string db = database.Text;
            string tbl = table.Text;
            string fd = field.Text;
            DB_Utility dbcon = new DB_Utility();
            dbcon.databaseConnect(usr, pwd, svr, db);

            SqlCommand SQLQuery = new SqlCommand();
            DataTable data = null;
            SqlTransaction transaction;
            transaction = dbcon.con.BeginTransaction();
            string queryString = "select stockid,stockname from stock ";
            SQLQuery.Connection = null;
            SqlDataAdapter dataAdapter = null;
            SQLQuery.CommandText = queryString;
            SQLQuery.Connection = dbcon.con;
            SQLQuery.Transaction = transaction;
            data = new DataTable();
            dataAdapter = new SqlDataAdapter(SQLQuery);
            dataAdapter.Fill(data);

            foreach (DataRow row in data.Rows)
            {
                string sid = row["stockid"].ToString();
                string sn = row["stockname"].ToString();
                string sn_uni = Converter.ZG2Uni(sn);

                string UpdateString = "update stock set stockname=@stockname where stockid=@stockid";
                SqlCommand sqlUpdate = new SqlCommand();
                sqlUpdate.CommandText = UpdateString;
                sqlUpdate.Connection = dbcon.con;
                sqlUpdate.Transaction = transaction;
                sqlUpdate.Parameters.AddWithValue("stockid", sid);
                sqlUpdate.Parameters.AddWithValue("stockname", sn_uni);
                sqlUpdate.ExecuteNonQuery();

                status.AppendText(sn_uni + Environment.NewLine);
            }
            
            transaction.Commit();
            dbcon.databaseDisconnect();
            success.Visible = true;
        }
    }
}
