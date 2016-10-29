using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicaFrba.Properties;
using System.Configuration;

namespace ClinicaFrba
{
    public class BDComun
    {
        public static string ObtenerString()
        {
            return Settings.Default.GD2C2016ConnectionString;

        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection(ObtenerString());

        Conn.Open();

            return Conn;
        }


    }
}
