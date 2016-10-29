using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaFrba.Properties;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClinicaFrba
{
    public class BDComun
    {
       public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("server=localhost\\SQLSERVER2012; initial catalog=GD2C2016; user id=gd; password=gd2016");
     
            conexion.Open();
            return conexion;
        }


        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public BDComun()
           {
            try
            {
                cn = new SqlConnection("server=localhost\\SQLSERVER2012; initial catalog=GD2C2016; user id=gd; password=gd2016");
                cn.Open();
               // MessageBox.Show("Conectado");
             }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos"+ex.ToString());
            }
           }

        public bool existeUsuario(string usuario)
        {
          try
              {
              cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM MISSINGNO.Usuario WHERE username='{0}'", usuario), cn);
              cmd.ExecuteNonQuery();
              return ((Int32)cmd.ExecuteScalar() >= 1);
              }
              catch(Exception ex)
              {
               //  MessageBox.Show("Error en verificar existencia" + ex.ToString());
                 return false;
              }
             
        }


        //@DESC: Dado un string lo encripta
        public static String encriptarSHA256(String str)
        {
            SHA256Managed hashManaged = new SHA256Managed();
            byte[] hash = hashManaged.ComputeHash(Encoding.Unicode.GetBytes(str));
            return BitConverter.ToString(hash);
        }


        public bool contraseñaCorrecta(string usuario, string contraseña)
        {
 
           try
              {
              cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM MISSINGNO.Usuario WHERE username='{0}' AND contrasenia=HASHBYTES('SHA2_256','{1}')", usuario, contraseña), cn);
              cmd.ExecuteNonQuery();
            return ((Int32)cmd.ExecuteScalar() >= 1);
              }
           catch (Exception ex)
           {
              // MessageBox.Show("Error en verificar datos" + ex.ToString());
               return false;
           }
        }
    
    
    }
}
