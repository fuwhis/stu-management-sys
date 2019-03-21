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
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlCommand sqlCommand = new SqlCommand(Sql, sqlConnection);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    sqlCommand.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            sqlAdapter.SelectCommand = sqlCommand;
            sqlAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public static bool ExecuteNonQuery(string Sql, params object[] parameters)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlCommand sqlCommand = new SqlCommand(Sql, sqlConnection);
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    sqlCommand.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            bool result = sqlCommand.ExecuteNonQuery() > 0;
            sqlConnection.Close();
            return result;
        }

        public static SqlDataReader ExecuteDataReader(string Sql, params object[] parameters)
        {
            SqlConnection sqlConnection = new SqlConnection(strConnection);
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = Sql;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    sqlCommand.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return dataReader;
        }

        
    }
}
