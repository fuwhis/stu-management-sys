using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_Group1_QLSvien.Models.Account
{
    class AccountUtils
    {
        public static bool checkLogin(string username, string password)
        {
            return DataProvider.DataProvider.ExecuteDataReader("SELECT * FROM ACCOUNT").Read();
        }
    }
}
