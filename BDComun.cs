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


        //--------LLAMADAS A SQL PARA LOGIN
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


        public void recuperarRolesHabilitados(string usuario, ComboBox roles, String rol)
        {
            try
              {
                  cmd = new SqlCommand(string.Format("SELECT rol_nombre FROM MISSINGNO.Rol AS X JOIN MISSINGNO.Rol_de_Usuario AS Y ON Y.rol_id = X.rol_id WHERE (Y.username='{0}' AND X.rol_habilitado = 1)",
                usuario), cn);                

            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //agrego los roles al combobox
                    roles.Items.Add(reader.GetString(0));
                }

                //si hay un solo rol para el usuario
                if (roles.Items.Count == 1)
                {
                    //ya tiene un rol
                    rol = roles.GetItemText(roles.Items[0]);
                }
                else
                {
                    //el combobox muestra el primer rol por default
                    roles.SelectedIndex = 0;
                }

                reader.Close();
  
            }

            reader.Close();

        }
                       catch (Exception ex)
           {
              MessageBox.Show("Error en verificar datos" + ex.ToString());
             
            }
        }
        //--------LLAMADAS A SQL PARA ADMINISTRAR AFILIADO





    }
}
