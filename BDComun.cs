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
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos" + ex.ToString());
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
            catch (Exception ex)
            {

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



        public int obtenerPlanId(string planDescripcion)
        {
            try
            {
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
            DateTime fecha = new DateTime(2000, 11, 11);
            int doc = Convert.ToInt32(numDocumento);
            UInt64 tel = Convert.ToUInt64(telefono);
            string genero = cifrarGenero(sexo);
            int idPlan = obtenerPlanId(planMedico);
            try
            {
                {
                    if (!existeUsuario(username))
                    {
                        cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Usuario (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , {2}, HASHBYTES('SHA2_256','{3}'), '{4}','{5}', '{6}' , '{7}', '{8}', '{9}', {10})",
                            // "afi", "DNI", 39064509, "afi", "afi", "afi", fecha, 'H', "Mi casa", "afi@gmail.com", 123), cn);
                            username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel), cn);
                        cmd.ExecuteNonQuery();
                    }

                    cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado, afiliado_baja_logica) VALUES ('{0}', {1} , '{2}', '{3}', {4}, {5})",
                        // "fam", 555555, "soltero", fecha, "NULL" , 1), cn);
                       username, idPlan, estadoCivil, "01/01/2018", idPlan, 1), cn);
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
                    if (!existeUsuario(username))
                    {
                        cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Usuario (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , {2}, HASHBYTES('SHA2_256','{3}'), '{4}','{5}', '{6}' , '{7}', '{8}', '{9}', {10})",
                            // "afi", "DNI", 39064509, "afi", "afi", "afi", fecha, 'H', "Mi casa", "afi@gmail.com", 123), cn);
                            username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel), cn);
                        cmd.ExecuteNonQuery();
                    }
                    cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado, afiliado_baja_logica) VALUES ('{0}', {1} , '{2}', '{3}', {4}, {5})",
                        // "fam", 555555, "soltero", fecha, idPadre, 1), cn);
                      username, idPlan, estadoCivil, "01/01/2018", idPlan, 1), cn);
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


        public int obtenerTurnoId(int consultaMedica)
        {
            try
            {
                int id = new int();
                cmd = new SqlCommand(string.Format("SELECT turno_id FROM MISSINGNO.Consulta_medica WHERE consulta_id = {0}",
                     consultaMedica), cn);
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
                MessageBox.Show("Error al obtener turno ID: " + ex.ToString());
                return -1;
            }

        }

        public void cancelarConsultaMedica(int numeroConsulta, string tipoCancelacion, string motivoCancelacion)
        {
            try
            {
                int numeroTurno = obtenerTurnoId(numeroConsulta);

                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Cancelacion_Turno(turno_id, cancelacion_motivo, cancelacion_tipo, cancelacion_fecha) VALUES ({0},'{1}','{2}',getDate())",
                    numeroTurno, tipoCancelacion, motivoCancelacion), cn);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cancelar Consulta Medica. Error: " + ex.ToString());
            }
        }

        public bool consultaYaCancelada(int consulta_id)
        {
            try
            {
                cmd = new SqlCommand(string.Format("SELECT count(*) FROM MISSINGNO.Cancelacion_Turno C, MISSINGNO.Consulta_medica CO  WHERE C.turno_id = CO.turno_id and CO.consulta_id = {0}",
                    consulta_id), cn);
                cmd.ExecuteNonQuery();
                return ((Int32)cmd.ExecuteScalar() >= 1);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool chequearConsultaMedica(int consulta_id, string usernameProfesional)
        {
            try
            {
                cmd = new SqlCommand(string.Format("SELECT count(*) FROM MISSINGNO.Consulta_medica C, MISSINGNO.Profesional P WHERE consulta_id= '{0}' and P.profesional_id = C.profesional_id and P.username = '{1}'",
                    consulta_id, usernameProfesional), cn);
                cmd.ExecuteNonQuery();
                return ((Int32)cmd.ExecuteScalar() >= 1);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /*
        public bool chequearConsultaMedica(int consulta_id, string usernameProfesional)
        {
            try
            {  
                cmd = new SqlCommand(string.Format("SELECT consulta_id FROM MISSINGNO.Consulta_medica C, MISSINGNO.Profesional P WHERE consulta_id= '{0}' and P.profesional_id = C.profesional_id and P.username = '{1}'",
                     consulta_id, usernameProfesional), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reader.GetInt32(0);
                }
                reader.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la ID Consulta, Error: " + ex.ToString());
                return bool;
            }

        }
        */



        public void borrarAfiliado(string username)
        {
            try
            {
                cmd = new SqlCommand(string.Format("Delete from MISSINGNO.Rol_de_Usuario where (username ='{0}' AND rol_id = 3); Delete From MISSINGNO.Afiliado where username='{0}'", username));
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


        //----------------------------CONEXIONES PARA EDITAR AFILIADO

        public AfiliadoCompleto obtenerDatosAfiliado(string username)
        {
            AfiliadoCompleto afiliado = new AfiliadoCompleto();
            try
            {
                cmd = new SqlCommand(string.Format("SELECT doc_tipo, doc_nro, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono, afiliado_estado_civil FROM MISSINGNO.Usuario as X , MISSINGNO.Afiliado AS Y WHERE (Y.username = '{0}' AND X.username = '{0}')",
                     username), cn);
                //SqlCommand comando = new SqlCommand(string.Format("SELECT doc_tipo, doc_nro, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono FROM MISSINGNO.Usuario WHERE username = '{0}'",
                //  username), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    afiliado.doc_tipo = reader.GetString(0);
                    afiliado.doc_nro = reader.GetInt64(1);
                    afiliado.nombre = reader.GetString(2);
                    afiliado.apellido = reader.GetString(3);
                    afiliado.fec_nac = reader.GetDateTime(4);
                    afiliado.sexo = reader.GetString(5);
                    afiliado.domicilio = reader.GetString(6);
                    afiliado.mail = reader.GetString(7);
                    afiliado.telefono = reader.GetInt64(8);
                    afiliado.afiliado_estado_civil = reader.GetString(9);
                }
                reader.Close();
                List<int> listaID = new List<int>();
                Int32 id = new Int32();
                int idAfiliado = this.obtenerAfiliadoId(username);
                cmd = new SqlCommand(string.Format("SELECT afiliado_id FROM  MISSINGNO.Afiliado WHERE afiliado_encargado = {0}",
                    idAfiliado), cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader2 = cmd.ExecuteReader();

                while (reader2.Read())
                {
                    id = reader2.GetInt32(0);
                    listaID.Add(id);
                }

                reader2.Close();
                afiliado.hijos = listaID;
                return afiliado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.ToString());
                return afiliado;
            }
        }


        public AfiliadoSimple obtenerDatosAfiliado(int afiliadoID)
        {
            AfiliadoSimple afiliado = new AfiliadoSimple();
            try
            {

                cmd = new SqlCommand(string.Format("SELECT X.username, nombre, apellido FROM MISSINGNO.Usuario as X JOIN MISSINGNO.Afiliado AS Y ON ( X.username = Y.username)WHERE (afiliado_id =  {0});",
                     afiliadoID), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    afiliado.username = reader.GetString(0);
                    afiliado.nombre = reader.GetString(1);
                    afiliado.apellido = reader.GetString(2);
                }
                reader.Close();
                return afiliado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de usuario: " + ex.ToString());
                return afiliado;
            }

        }

        public void modificarAfiliado(string username, string tipoDocumento, string numDocumento, string contraseña, string nombre, string apellido, DateTime fechaNacimiento, string sexo, string direccion, string email, string telefono, string estadoCivil, string planMedico)
        {

            int doc = Convert.ToInt32(numDocumento);
            UInt64 tel = Convert.ToUInt64(telefono);
            string genero = cifrarGenero(sexo);
            int idPlan = obtenerPlanId(planMedico);
            DateTime fecha = new DateTime(2000, 11, 11);
            try
            {
                cmd = new SqlCommand(string.Format("UPDATE MISSINGNO.Usuario SET doc_tipo='{0}', doc_nro={1}, contrasenia = '{2}', nombre= '{3}', apellido='{4}', fec_nac='{5}', sexo='{6}', domicilio='{7}', mail= '{8}', telefono = {9} WHERE username='{10}'",
                    tipoDocumento, doc, contraseña, nombre, apellido, fecha, genero, direccion, email, tel, username), cn);
                //"DNI", 39064509, "asdasd", "afi3", "afi", fecha, "H", "casa", "asasdsa", 01146969696969, "afi"),cn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(string.Format("UPDATE MISSINGNO.Afiliado SET plan_id={0}, afiliado_estado_civil='{1}' WHERE username='{2}'",
                idPlan, estadoCivil, username), cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.ToString());
            }
        }

        public List<Palabra> obtenerEspecialidades()
        {
            List<Palabra> especialidades = new List<Palabra>();

            try
            {
                cmd = new SqlCommand("SELECT especialidad_descripcion FROM MISSINGNO.Especialidad", cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Palabra especialidad = new Palabra();
                    especialidad.unElemento = reader.GetString(0);
                    especialidades.Add(especialidad);

                }
                reader.Close();
                return especialidades;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener especialidades: " + ex.ToString());
                return especialidades;
            }
        }

        /*  public List<Palabra> obtenerProfesionalesPorEspecialidad(string especialidad)  
         {
             List<Palabra> especialidades = new List<Palabra>();
           
            try
               {
                   cmd = new SqlCommand(string.Format("SELECT distinct (SELECT username FROM MISSINGNO.Profesional WHERE profesional_id= 6) FROM MISSINGNO.Especialidad_de_profesional WHERE especialidad_id = (SELECT especialidad_id FROM MISSINGNO.Especialidad WHERE especialidad_descripcion = '{0}')",
                       especialidad), cn);
                  cmd.ExecuteNonQuery();
                  SqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read())
                  {
                      Palabra esp = new Palabra();
                      esp.unElemento = reader.GetString(0);
                      especialidades.Add(esp);

                  }
                  reader.Close();
                  return especialidades;
               }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener especialidades: " + ex.ToString());
                return especialidades;
            }
         }

 */
        public int obtenerPlanIdDeAfiliado(String username)
        {
            int id = new int();
            try
            {
                cmd = new SqlCommand(string.Format("SELECT plan_id FROM MISSINGNO.Afiliado WHERE username = '{0}'",
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
                MessageBox.Show("Error al obtener turno ID: " + ex.ToString());
                return -1;
            }
        }


        public int obtenerBonoPrecio(String username)
        {
            int precio = new int();
            try
            {
                cmd = new SqlCommand(string.Format("select cast(bono_precio_consulta as int) from MISSINGNO.Planes P, MISSINGNO.Afiliado A where A.username = '{0}' and A.plan_id = P.plan_id",
                    username), cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    precio = reader.GetInt32(0);
                }
                reader.Close();
                return precio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error el precio: " + ex.ToString());

                return -1;
            }


        }


        public int agregarBono(int planid, int afiliadoId, int compraBonoId, int bonoPrecio)
        {
            try
            {
                int id = new int();
                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Bono(plan_id,afiliado_id,compra_bono_id,bono_estado,bono_precio) OUTPUT inserted.bono_id VALUES ({0},{1},{2},1,{3})",
                    planid, afiliadoId, compraBonoId, bonoPrecio), cn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                return id;
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Error al crear bono ID: " + ex2.ToString());
                return -1;
            }
        }

        public void comprarBonos(int cantidadBonos, String username)
        {
            int afiliadoId = obtenerAfiliadoId(username);
            int planid = obtenerPlanIdDeAfiliado(username);
            int compraBonoId = new int();
            int bonoPrecio = obtenerBonoPrecio(username);

            try
            {
                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Compra_Bono(afiliado_id,plan_id,fecha_compra) OUTPUT inserted.compra_bono_id VALUES ({0},{1},getDate())",
                    afiliadoId, planid), cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    compraBonoId = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear compra bono ID: " + ex.ToString());
            }

            int i;
            int bono;

            for (i = 0; i < cantidadBonos; i++)
            {
                bono = agregarBono(planid, afiliadoId, compraBonoId, bonoPrecio);
                MessageBox.Show("BONO COMPRADO: " + bono);
            }


        }

    }
}
