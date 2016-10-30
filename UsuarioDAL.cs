using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace ClinicaFrba
{

    class UsuarioDAL
    {

    /*   // BDComun c = new BDComun();
        public static AfiliadoSimple Buscar_afiliado_por_username(string username)
        {

            
                AfiliadoSimple afiliado = new AfiliadoSimple();
                SqlCommand comando = new SqlCommand(String.Format(
                "SELECT afiliado_id, username FROM MISSIGNO.Afiliado where username ='{0}'", username));
                 SqlDataReader reader = comando.ExecuteReader();
                 while (reader.Read())
                  {
                     afiliado.afiliado_id = reader.GetInt32(0);
                     afiliado.username = reader.GetString(1);
                  }
            
            return afiliado;

        }
        public static string cifrarGenero(string genero)
        {
            if (genero == "Hombre")
            { return "H"; }
            else
            { return "M"; }
        }

        public static void crearAfiliado(string username, string tipoDocumento, string numDocumento, string contraseña, string nombre, string apellido, DateTime fechaNacimiento, string sexo, string direccion, string email, string telefono, string estadoCivil, string planMedico, string encargado) {

            int doc = Convert.ToInt32(numDocumento);
            int tel = Convert.ToInt32(telefono);
            int plan = Convert.ToInt32(planMedico);
            string genero = cifrarGenero(sexo);

            {
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Usuarios (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , {2}, '{3}', '{4}', '{5}', '{6}' , '{7}', '{8}', '{9}', {10})",
                 username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel));

            SqlCommand otroComando = new SqlCommand(string.Format("INSERT INTO Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado) VALUES ('{0}', {1} , '{2}', '{3}', '{4}')",
                username, plan, estadoCivil, "01/01/2018", encargado));
            
            }
        }


        public static void borrarAfiliado(string username)
        {
            //int retorno = 0;
            
                SqlCommand comando = new SqlCommand(string.Format("Delete From Afiliado where username='{0}'", username));
             

            //retorno = comando.ExecuteNonQuery();

           // return retorno;
        }

      
/*
        private bool usuarioHabilitado()
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.USUARIO WHERE ";
            cmd.CommandText += "username = '" + textBox_usr.Text + "' ";
            cmd.CommandText += "AND USUARIO_HABILITADO = 1"; //EL CAMPO USUARIO_HABILITADO SE LLENA CON 1 PARA INDICAR HABILITACION
            cmd.Connection = sqlCon;

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() < 1)
            {
                MessageBox.Show("El usuario se ha inhabilitado, contáctese con el administrador.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            //libero
            cmd.Dispose();
            return true;
        }
*/




    }
}
