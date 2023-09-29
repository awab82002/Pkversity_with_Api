using ClassLibraryEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class CityService:ICityController
    {
        public  List<EntCities> GetCities()
        {
            List<EntCities> CitiesList = new List<EntCities>();
            try
            {


                SqlConnection con = DBHelper.GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_GetCities", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    EntCities ee = new EntCities();
                    ee.CityId = sdr["CityId"].ToString();
                    ee.CityName = sdr["CityName"].ToString();
                    ee.CityCode = sdr["CityCode"].ToString();
                    CitiesList.Add(ee);
                }
                con.Close();

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            return CitiesList;
        }
    }
}
