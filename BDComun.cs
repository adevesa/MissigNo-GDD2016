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


        //----------------------------------------------LLAMADAS A SQL PARA LOGIN

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
                 cmd.ExecuteNonQuery();
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
        //----------------------------------------LLAMADAS A SQL PARA ADMINISTRAR AFILIADO

     /*   public AfiliadoSimple Buscar_afiliado_por_username(string username)
        {

            AfiliadoSimple afiliado = new AfiliadoSimple();
            try{
            cmd = new SqlCommand(String.Format(
            "SELECT afiliado_id, username FROM MISSIGNO.Afiliado where username ='{0}'", username), cn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                afiliado.afiliado_id = reader.GetInt32(0);
                afiliado.username = reader.GetString(1);
            }

            return afiliado;
           }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar afiliado: " + ex.ToString());
                return afiliado;
            }

        }*/
        public string cifrarGenero(string genero)
        {
            if (genero == "Hombre")
            { return "H"; }
            else
            { return "M"; }
        }

        public int obtenerAfiliadoId(string username)
        {
            try
            {
                int id = new int();
                cmd = new SqlCommand(string.Format("SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE username= '{0}'",
                     username), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener afiliado ID: " + ex.ToString());
                return -1;
            }

        }



        public int obtenerPlanId(string planDescripcion){
             try{
                 int id = new int();
                 cmd = new SqlCommand(string.Format("SELECT plan_id FROM MISSINGNO.Planes WHERE plan_descripcion= '{0}'",
                      planDescripcion), cn);
                  cmd.ExecuteNonQuery();
                 
                  SqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read())
                  {
                    id = reader.GetInt32(0);
                }
                  reader.Close();
               return id;
               }  
             catch (Exception ex)
             {
                 MessageBox.Show("Error al obtener plan ID: " + ex.ToString());
                return -1;
             }

        }

        public void crearAfiliado(string username, string tipoDocumento, string numDocumento, string contraseña, string nombre, string apellido, DateTime fechaNacimiento, string sexo, string direccion, string email, string telefono, string estadoCivil, string planMedico)
        {
            DateTime fecha= new DateTime(2000, 11, 11);
            int doc = Convert.ToInt32(numDocumento);
            UInt64 tel = Convert.ToUInt64(telefono);
            string genero = cifrarGenero(sexo);
            int idPlan = obtenerPlanId(planMedico);
            try{
            {

                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Usuario (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , {2}, HASHBYTES('SHA2_256','{3}'), '{4}','{5}', '{6}' , '{7}', '{8}', '{9}', {10})",
                    // "afi", "DNI", 39064509, "afi", "afi", "afi", fecha, 'H', "Mi casa", "afi@gmail.com", 123), cn);
                    username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel), cn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado, afiliado_baja_logica) VALUES ('{0}', {1} , '{2}', '{3}', {4}, {5})",
                  "fam", 555555, "soltero", fecha, "NULL" , 1), cn);
                //   username, idPlan, estadoCivil, "01/01/2018", encargado, 1), cn);
                cmd.ExecuteNonQuery();

                 cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Rol_de_Usuario (rol_id, username) VALUES (3, '{0}')", username),cn);
                 cmd.ExecuteNonQuery();

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear afiliado. Error: " + ex.ToString());
            }
                          
        }


        public void crearFamiliar(string username, string tipoDocumento, string numDocumento, string contraseña, string nombre, string apellido, DateTime fechaNacimiento, string sexo, string direccion, string email, string telefono, string estadoCivil, string planMedico, int idPadre)
        {
            DateTime fecha = new DateTime(2000, 11, 11);
            int doc = Convert.ToInt32(numDocumento);
            UInt64 tel = Convert.ToUInt64(telefono);
            string genero = cifrarGenero(sexo);
            int idPlan = obtenerPlanId(planMedico);
            try
            {
                {

                    cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Usuario (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , {2}, HASHBYTES('SHA2_256','{3}'), '{4}','{5}', '{6}' , '{7}', '{8}', '{9}', {10})",
                        // "afi", "DNI", 39064509, "afi", "afi", "afi", fecha, 'H', "Mi casa", "afi@gmail.com", 123), cn);
                        username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel), cn);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado, afiliado_baja_logica) VALUES ('{0}', {1} , '{2}', '{3}', {4}, {5})",
                      "fam", 555555, "soltero", fecha, idPadre, 1), cn);
                    //   username, idPlan, estadoCivil, "01/01/2018", encargado, 1), cn);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Rol_de_Usuario (rol_id, username) VALUES (3, '{0}')", username), cn);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear afiliado. Error: " + ex.ToString());
            }

        }





        public void borrarAfiliado(string username)
        {
            try{
                SqlCommand comando = new SqlCommand(string.Format("Delete from MISSINGNO.Rol_de_Usuario where (username ='{0}' AND rol_id = 3); Delete From MISSINGNO.Afiliado where username='{0}'", username));
            cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar afiliado. Error: " + ex.ToString());
            }
        }

        public void recuperarPlanes(ComboBox planes, String plan)
        {
           try
              {
                  cmd = new SqlCommand("SELECT plan_descripcion FROM MISSINGNO.Planes", cn);                
                 cmd.ExecuteNonQuery();
            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //agrego los roles al combobox
                    planes.Items.Add(reader.GetString(0));
                }

                //si hay un solo rol para el usuario
                if (planes.Items.Count == 1)
                {
                    //ya tiene un rol
                    plan = planes.GetItemText(planes.Items[0]);
                }
                else
                {
                    //el combobox muestra el primer rol por default
                    planes.SelectedIndex = 0;
                }

                reader.Close();
  
            }

            reader.Close();

        }
                       catch (Exception ex)
           {
              MessageBox.Show("Error al buscan planes" + ex.ToString());
             
            }
        }        

    }
}
