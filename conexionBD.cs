using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClinicaFrba
{
    public class conexionBD
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=GD2C2016; Uid=gd; pwd=gd2016;");

            conectar.Open();
            return conectar;
        }
                     
    }
}
