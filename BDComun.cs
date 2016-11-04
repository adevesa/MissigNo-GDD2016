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

        public void cancelarTurno(int numeroTurno, string tipoCancelacion, string motivoCancelacion)
        {
            try
            {
                SqlCommand comando = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Cancelacion_Turno(turno_id, cancelacion_motivo, cancelacion_tipo, cancelacion_fecha) VALUES ({0},'{1}','{2}',getDate())",
                    numeroTurno, tipoCancelacion, motivoCancelacion), cn);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cancelar Turno. Error: " + ex.ToString());
            }
        }

        public bool turnoYaCancelado(int turno_id)
        {
            try
            {
                cmd = new SqlCommand(string.Format("SELECT count(*) FROM MISSINGNO.Cancelacion_Turno C, MISSINGNO.Turno T WHERE C.turno_id = T.turno_id and T.turno_id = {0}",
                    turno_id), cn);
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


        public void recuperarEnComboBox(string profesional, ComboBox especialidades)
             {
            try
            {
                cmd = new SqlCommand(string.Format("SELECT E.especialidad_descripcion FROM MISSINGNO.Especialidad AS E, MISSINGNO.Especialidad_de_profesional AS EP WHERE (E.especialidad_id = EP.especialidad_id AND EP.profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username='{0}'))",
                    profesional),cn);
                  cmd.ExecuteNonQuery();
                  SqlDataReader reader = cmd.ExecuteReader();
                  if (reader.HasRows)
                  {
                      while (reader.Read())
                      {
                          //agrego los roles al combobox
                          especialidades.Items.Add(reader.GetString(0));
                      }

                      //si hay un solo rol para el usuario
                      if (especialidades.Items.Count == 1)
                      {
                          //ya tiene un rol
                          string especialidad = especialidades.GetItemText(especialidades.Items[0]);
                      }
                      else
                      {
                          //el combobox muestra el primer rol por default
                          especialidades.SelectedIndex = 0;
                      }

                      reader.Close();

                  }

                  reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar especialidades" + ex.ToString());

            }
             }



        //----------------------------CONEXIONES PARA EDITAR AFILIADO

        public AfiliadoCompleto obtenerDatosAfiliadoCompleto(string username)
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


        public AfiliadoSimple obtenerDatosAfiliadoSimple(int afiliadoID)
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

    public List<Palabra> obtenerProfesionalesPorEspecialidad(string especialidad)  
        {
            List<Palabra> especialidades = new List<Palabra>();
           
           try
              {
                  cmd = new SqlCommand(string.Format("SELECT P.username FROM MISSINGNO.Profesional AS P, MISSINGNO.Especialidad_de_profesional AS EP WHERE (P.profesional_id = EP.profesional_id AND EP.especialidad_id = (SELECT especialidad_id FROM MISSINGNO.Especialidad WHERE especialidad_descripcion = '{0}'))",
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

        
        public List<tipoTurno> obtenerTurnos(string usernameAfi, string usernameProf){
            List<tipoTurno> turnos = new List<tipoTurno>();
           try
              {
                  cmd = new SqlCommand(string.Format("SELECT T.turno_id, T.fecha, T.horario FROM MISSINGNO.Turno AS T, MISSINGNO.BONO AS B  WHERE T.profesional_id= (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username = '{0}' ) AND T.bono_id = B.bono_id AND B.afiliado_id = (SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE username= '{1}') AND T.en_uso = 0",
                      usernameAfi, usernameProf), cn);
                  cmd.ExecuteNonQuery();
                  SqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read())
                  {
                      tipoTurno turno = new tipoTurno();
                      turno.idTurno = reader.GetInt32(0);
                      turno.fechaTurno = reader.GetDateTime(1);
               
                      turnos.Add(turno);

                  }
                  reader.Close();
                  return turnos;
              }
           catch (Exception ex)
           {
               MessageBox.Show("Error al obtener turnos: " + ex.ToString());
               return turnos;
           }
        }
        public void generarConsulta(string usernameAfi, string especialidad, string usernameProf, int idTurno)
        {

             try
              {
                  cmd = new SqlCommand(string.Format(" INSERT INTO MISSINGNO.Consulta_medica (profesional_id, afiliado_id, agenda_id, turno_id, confirmacion_de_atencion, consulta_horario) VALUES ((SELECT profesional_id FROM MISSINGNO.Profesional WHERE username='{0}'), (SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE username = '{1}'), (SELECT agenda_id FROM MISSINGNO.Agenda WHERE prof_esp_id = (SELECT prof_esp_id FROM MISSINGNO.Especialidad_de_profesional WHERE (profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username='{0}') AND especialidad_id = (SELECT especialidad_id FROM MISSINGNO.Especialidad WHERE especialidad_descripcion = '{2}')))), {3}, 'NO', (SELECT horario FROM MISSINGNO.Turno WHERE turno_id = {3}))",
                 usernameProf, usernameAfi, especialidad ,idTurno), cn);
                  cmd.ExecuteNonQuery();

                  cmd = new SqlCommand(string.Format("UPDATE MISSINGNO.Turno SET en_uso = 1 WHERE turno_id = {0}",
                      idTurno), cn);
                cmd.ExecuteNonQuery();
             }
         catch (Exception ex)
           {
               MessageBox.Show("Error al generar consulta: " + ex.ToString());
           }
        }


        
        
        
        
        public int desdeDia(string profesional, string dia)
             {
                 int horario= new int();
             try
              {
                  cmd = new SqlCommand(string.Format("SELECT D.horario_desde FROM MISSINGNO.Dia AS D, MISSINGNO.Agenda AS A, MISSINGNO.Especialidad_de_profesional AS EP WHERE (D.agenda_id = A.agenda_id AND A.prof_esp_id = EP.prof_esp_id AND D.desc_dia = '{1}' AND EP.profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username = '{0}'))",
                      profesional, dia),cn);
                      cmd.ExecuteNonQuery();
                      return horario;
                      SqlDataReader reader = cmd.ExecuteReader();
                      while (reader.Read())
                      {
                         horario = reader.GetInt32(0);
                      }
                      reader.Close();
                      return horario;

              }
             catch (Exception ex)
             {
                 MessageBox.Show("Error en desdeDia: " + ex.ToString());
                 return horario;
             }
             }

        public int hastaDia(string profesional, string dia)
        {
            int horario = new int();
            try
            {
                cmd = new SqlCommand(string.Format("SELECT D.horario_hasta FROM MISSINGNO.Dia AS D, MISSINGNO.Agenda AS A, MISSINGNO.Especialidad_de_profesional AS EP WHERE (D.agenda_id = A.agenda_id AND A.prof_esp_id = EP.prof_esp_id AND D.desc_dia = '{1}' AND EP.profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username = '{0}'))",
                    profesional, dia), cn);
                cmd.ExecuteNonQuery();
                return horario;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horario = reader.GetInt32(0);
                }
                reader.Close();
                return horario;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en desdeDia: " + ex.ToString());
                return horario;
            }
        }


        public void generarDia(string dia, string horaInicio, string horaFin, int agendaId)
        {
            try
            {
                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Dia(agenda_id,horario_desde,horario_hasta,desc_dia) VALUES ({0},cast('{1}' as time), cast('{2}' as time),'{3}')",
                    agendaId, horaInicio, horaFin, dia), cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear dia: " + ex.ToString());
            }
        }

        public int conseguirIdporUsernameYespecialidad(String username, String especialidad)
        {
            try
            {   int id = new int();
                cmd = new SqlCommand(string.Format("SELECT prof_esp_id FROM MISSINGNO.Especialidad_de_profesional EP, MISSINGNO.Profesional P, MISSINGNO.Especialidad E where EP.profesional_id = P.profesional_id AND P.username = '{0}' AND EP.especialidad_id = E.especialidad_id AND E.especialidad_descripcion = '{1}'",
                    username, especialidad), cn);
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
                MessageBox.Show("Error al conseguir prof_esp_id: " + ex.ToString());
                return -1;
            }
        }


        public int generarAgenda(String username, DateTime fecha_inicio, DateTime fecha_fin, String especialidad)
        {
            try
            {
                int agendaId = new int();
                int profEspId = new int();
                profEspId = conseguirIdporUsernameYespecialidad(username, especialidad);
                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Agenda(prof_esp_id,agenda_inicio,agenda_fin) OUTPUT inserted.agenda_id VALUES ({0},'{1}','{2}')",
                    profEspId, fecha_inicio, fecha_fin), cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    agendaId = reader.GetInt32(0);
                }
                reader.Close();
                return agendaId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear agenda: " + ex.ToString());
                return -1;
            }

        }

        public bool yaExisteAgenda(String username, String especialidad)
        {
            try
            {
                int id = new int();
                cmd = new SqlCommand(string.Format("SELECT count(*) FROM MISSINGNO.Agenda A ,MISSINGNO.Especialidad_de_profesional EP, MISSINGNO.Profesional P, MISSINGNO.Especialidad E where EP.profesional_id = P.profesional_id AND P.username = '{0}'  AND EP.especialidad_id = E.especialidad_id AND E.especialidad_descripcion = '{1}' AND A.prof_esp_id = EP.prof_esp_id",
                username, especialidad),cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                return (id>0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir prof_esp_id: " + ex.ToString());
                return false;
            }
        }

        public bool esAfiliado(String username)
        {
            try
            {
                int id = new int();
                cmd = new SqlCommand(string.Format("SELECT count(*) FROM MISSINGNO.Afiliado where username = '{0}'",
                    username), cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                return (id > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir afiliado: " + ex.ToString());
                return false;
            }
        }

        public void modificarConsulta(string idConsulta, string diagnostico, string sintoma, string estado)
            {
                int id = Convert.ToInt32(idConsulta);
            try
                 {
                     cmd = new SqlCommand(string.Format("UPDATE MISSINGNO.Consulta_medica SET diagnostico='{0}', sintoma='{1}', confirmacion_de_atencion='{2}' WHERE consulta_id={3}",
                    diagnostico, sintoma, estado, idConsulta), cn);
                     cmd.ExecuteNonQuery();
                 }
            catch (Exception ex)
                {
                MessageBox.Show("Error al modificar consulta: " + ex.ToString());
                }
            }

        public void turnosSinUsarProf (string profesional, ComboBox idTurno) {
            List<string> turnos = new List<string>(); 
            try
                 {
                     cmd = new SqlCommand(string.Format("SELECT turno_id FROM MISSINGNO.Turno WHERE (profesional_id = (SELECT profesional_id FROM  MISSINGNO.Profesional WHERE username='{0}') AND en_uso = 0)",
                        profesional), cn);
                     cmd.ExecuteNonQuery();
                     SqlDataReader reader = cmd.ExecuteReader();
                         if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //agrego los roles al combobox
                        idTurno.Items.Add(Convert.ToString(reader.GetInt32(0)));
                    }

                    //si hay un solo rol para el usuario
                    if (idTurno.Items.Count == 1)
                    {
                        //ya tiene un rol
                        string turno;
                        turno = idTurno.GetItemText(idTurno.Items[0]);
                    }
                    else
                    {
                        //el combobox muestra el primer rol por default
                        idTurno.SelectedIndex = 0;
                    }

                    reader.Close();

                }

                reader.Close();
                 }
             catch (Exception ex)
             {
                 MessageBox.Show("Error al cargar turnos: " + ex.ToString());
             }
        }

        public void turnosSinUsarAfi(string afiliado, ComboBox idTurno)
        {
            List<string> turnos = new List<string>();
            try
            {
                cmd = new SqlCommand(string.Format("SELECT T.turno_id FROM MISSINGNO.Turno AS T, MISSINGNO.Bono AS B WHERE (en_uso = 0 AND T.bono_id = B.bono_id AND B.afiliado_id = (SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE username ='{0}' ))",
                   afiliado), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //agrego los roles al combobox
                        idTurno.Items.Add(Convert.ToString(reader.GetInt32(0)));
                    }

                    //si hay un solo rol para el usuario
                    if (idTurno.Items.Count == 1)
                    {
                        //ya tiene un rol
                        string turno;
                        turno = idTurno.GetItemText(idTurno.Items[0]);
                    }
                    else
                    {
                        //el combobox muestra el primer rol por default
                        idTurno.SelectedIndex = 0;
                    }

                    reader.Close();

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar turnos: " + ex.ToString());
            }
        }

        public int obtenerAgendaId(String username, String especialidad)
        {
            try
            {
                int prof_esp_id = conseguirIdporUsernameYespecialidad(username, especialidad);
                int id = new int();
                cmd = new SqlCommand(string.Format("Select agenda_id from MISSINGNO.Agenda where prof_esp_id = {0}",
                    prof_esp_id), cn);
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
                TimeSpan horario2 = new TimeSpan();
                MessageBox.Show("Error al agenda ID: " + ex.ToString());
                return -1;
            }
        }

        /*
        public void verTurnos(string Dia, String username, String especialidad)
        {
            int agendaId = obtenerAgendaId(username, especialidad);
            List<TimeSpan> Turnos = turnoEntreHorario(Dia, agendaId);
            for (int x = 0; x < Turnos.Count; x++)
            {
                MessageBox.Show(Convert.ToString(Turnos[x]));
            }
        }
         */

        public String traductorDiaDeLaSemana(String dia)
        {
            switch(dia)
            {
                case ("Monday"): return "Lunes";
                case ("Tuesday"): return "Martes";
                case ("Wednesday"): return "Miercoles";
                case ("Thursday"): return "Jueves";
                case ("Friday"): return "Viernes";
                case ("Saturday"): return "Sabado";
                case ("Sunday"): return "Domingo";
                default: return "Nada";
            }

        }

        public List<TimeSpan> turnosEnFecha(DateTime fecha, String username, String especialidad)
        {
          int agendaId = obtenerAgendaId(username,especialidad);
          //MessageBox.Show(traductorDiaDeLaSemana(Convert.ToString(fecha.DayOfWeek)));
          return(turnoEntreHorario(traductorDiaDeLaSemana(Convert.ToString(fecha.DayOfWeek)), agendaId));
        }

        
        public List<TimeSpan> turnoEntreHorario(string Dia, int agendaId)
        {
            List<TimeSpan> Turnos = new List<TimeSpan>();
            TimeSpan horario_Desde = horarioDesde(Dia, agendaId);
            TimeSpan horario_Hasta = horarioHasta(Dia, agendaId);
            TimeSpan horario_progresivo = new TimeSpan();
            TimeSpan treinta_minutos = new TimeSpan(00,30,00);
            for (horario_progresivo = horario_Desde; horario_progresivo <= horario_Hasta; horario_progresivo += treinta_minutos)
            {
                Turnos.Add(horario_progresivo);
            }
            return Turnos;
        }



        public TimeSpan horarioDesde(string Dia, int agendaId)
        {
            try
            {
                TimeSpan horario = new TimeSpan();
                cmd = new SqlCommand(string.Format("SELECT horario_desde FROM MISSINGNO.Dia D,MISSINGNO.Agenda A WHERE D.desc_dia = '{0}' AND A.Agenda_id = {1} AND A.agenda_id = D.agenda_id",
                   Dia, agendaId), cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horario = reader.GetTimeSpan(0);
                }
                reader.Close();
                return horario;
            }
            catch (Exception ex)
            {
                TimeSpan horario2 = new TimeSpan();
                MessageBox.Show("Error al conseguir horario Desde: " + ex.ToString());
                return horario2;
            }
        }

        public TimeSpan horarioHasta(string Dia, int agendaId)
        {
            try
            {
                TimeSpan horario = new TimeSpan();
                cmd = new SqlCommand(string.Format("SELECT horario_hasta FROM MISSINGNO.Dia D,MISSINGNO.Agenda A WHERE D.desc_dia = '{0}' AND A.Agenda_id = {1} AND A.agenda_id = D.agenda_id",
                   Dia, agendaId), cn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    horario = reader.GetTimeSpan(0);
                }
                reader.Close();
                MessageBox.Show("" + horario);
                return horario;
            }
            catch (Exception ex)
            {
                TimeSpan horario2 = new TimeSpan();
                MessageBox.Show("Error al conseguir horario Hasta: " + ex.ToString());
                return horario2;
            }
            }

        public List<TimeSpan> horariosUsados(DateTime Fecha, string profesional)
        {
            List<TimeSpan> horarios = new List<TimeSpan>();
            try
            {
                 cmd = new SqlCommand(string.Format("SELECT horario FROM MISSINGNO.Turno WHERE (fecha =   '{0}' AND profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username= '{1}'))",
                  // "2016-12-12 00:00:00.000", "renzo_Toledo@gmail.com"), cn);
                Fecha, profesional), cn);

               

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TimeSpan horario = new TimeSpan();
                    horario = reader.GetTimeSpan(0);
                    horarios.Add(horario);
                }
                reader.Close();

                return horarios;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conseguir horario de los turnos: " + ex.ToString());
                return horarios;
            }
        }
        
       public int crearTurno(string userProfesional,int bonoId,DateTime fecha,TimeSpan horario)
            {
              int idTurno = new int();
            try
            {
                cmd = new SqlCommand(string.Format("INSERT INTO MISSINGNO.Turno (profesional_id, bono_id, fecha, horario, en_uso) VALUES((SELECT profesional_id FROM MISSINGNO.Profesional WHERE username ='{0}'), {1} ,'{2}', '{3}', 0)",
                    userProfesional, bonoId, fecha, horario), cn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(string.Format("UPDATE MISSINGNO.Bono SET bono_estado = 1 WHERE bono_id = {0}",
               bonoId), cn);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(string.Format("SELECT turno_id FROM MISSINGNO.Turno WHERE (profesional_id = (SELECT profesional_id FROM MISSINGNO.Profesional WHERE username='{0}') AND bono_id = {1} AND fecha = '{2}' AND horario = '{3}')",
                    userProfesional, bonoId, fecha, horario), cn);
                cmd.ExecuteNonQuery();

               
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    idTurno = reader.GetInt32(0);
                    
                }
                reader.Close();
                return idTurno;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al crear turno: " + ex.ToString());
                return idTurno;
            }
            }

        public void bonosDeAfiliado(string userAfiliado, ComboBox bonos)
               {
            try
            {
                cmd = new SqlCommand(string.Format("SELECT bono_id From MISSINGNO.Bono WHERE (afiliado_id = (SELECT afiliado_id FROM MISSINGNO.Afiliado WHERE username='{0}') AND bono_estado=0)",
                    userAfiliado), cn);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //agrego los roles al combobox
                        bonos.Items.Add(Convert.ToString(reader.GetInt32(0)));
                    }

                    //si hay un solo rol para el usuario
                    if (bonos.Items.Count == 1)
                    {
                        //ya tiene un rol
                        string bono;
                        bono = bonos.GetItemText(bonos.Items[0]);
                    }
                    else
                    {
                        //el combobox muestra el primer rol por default
                        bonos.SelectedIndex = 0;
                    }

                    reader.Close();

                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bonos: " + ex.ToString());
            }
        }



    }
}

