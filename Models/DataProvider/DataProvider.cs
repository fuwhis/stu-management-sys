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
        static string strConnection;

        public DataProvider()
        {
            strConnection = getConnectionString(); 
        }

        public string getConnectionString()
        {
            return "server=.;database=QLSVien;uid=sa;pwd=12345678";
        }

        public static SqlDataReader ExecuteDataReader(string Sql, params object[] parameters)
        {
            SqlConnection cn = new SqlConnection(strConnection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = Sql;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue((i + 1) + "", parameters[i]);
                }
            }
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
