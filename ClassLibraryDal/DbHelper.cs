using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryDal
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AttendanceDB;Integrated Security=True;TrustServerCertificate=True");
            return con;
        }
    }
}