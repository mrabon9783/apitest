using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using restapi.Models;
using Microsoft.SqlServer;
using System.Data;
namespace restapi
{
    public class DeliveryDashboardPersistence
    {
        private System.Data.SqlClient.SqlConnection conn;

        public DeliveryDashboardPersistence()
        {

            string myconnstr;
            myconnstr = "Server=tcp:botwsmdr.database.windows.net,1433;Initial Catalog=wsbot;Persist Security Info=False;User ID=USERID;Password=PASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cnn;
            cnn = new SqlConnection(myconnstr);

        }

        public long saveddb(DeliveryDashboard dbtosave)
        {
            DeliveryDashboard ddb = new DeliveryDashboard();

            ddb.BoardDate = DateTime.Parse("12/31/9999");
            ddb.id = 1;
            ddb.MissingDocuments = 11;
            ddb.TotalLoans = dbtosave.TotalLoans;
            string sqlstring = "Insert into Table_1 (name) values('" + dbtosave.TotalLoans.ToString() + "')";
            string myconnstr;
            myconnstr = "Server=tcp:botwsmdr.database.windows.net,1433;Initial Catalog=wsbot;Persist Security Info=False;User ID=mdrabon;Password=T!nk3r123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cnn;
            cnn = new SqlConnection(myconnstr);
            cnn.Open();
            SqlCommand command = new SqlCommand(sqlstring, cnn);
            command.ExecuteNonQuery();


            return (1);
        }
        public string fetchdb(string sql)
        {
            DeliveryDashboard ddb = new DeliveryDashboard();
            string myconnstr;
            myconnstr = "Server=tcp:botwsmdr.database.windows.net,1433;Initial Catalog=wsbot;Persist Security Info=False;User ID=mdrabon;Password=T!nk3r123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            

            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(myconnstr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return serializer.Serialize(rows);
            
        }
    }
}