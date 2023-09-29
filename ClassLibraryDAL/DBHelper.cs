using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
           SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=db_pkversity;Integrated Security=True");
           //SqlConnection con = new SqlConnection(@"Data Source=65.108.97.18;Initial Catalog=db_pkversity; User ID=user_pkversity; password=y^7R7lv28");
           //SqlConnection con = new SqlConnection(@"Data Source=pkversity.database.windows.net;Initial Catalog=db_pkversity;User ID=db_pkversity;Password=earthandworld.985;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return con;

        }

    }
}