using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_Group1_QLSvien.Models.DataProvider
{
    public class DataProvider
    {
        private static string strConnection = ConfigurationManager.ConnectionStrings["QLSVien"].ConnectionString;

        public static DataTable ExecuteQuery(string Sql, params object[] parameters)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static bool ExecuteNonQuery(string Sql, params object[] parameters)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand(Sql, conn);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            bool result = cmd.ExecuteNonQuery() > 0;
            conn.Close();
            return result;
        }

        public static SqlDataReader ExecuteDataReader(string Sql, params object[] parameters)
        {
            SqlConnection conn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = Sql;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
