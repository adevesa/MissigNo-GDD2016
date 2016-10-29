using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ClinicaFrba
{
    public partial class Principal : Form
    {
        private SqlConnection sqlCon = null;

        private String usuario = null;

        private String rol = null;

        public Principal()
        {
            InitializeComponent();
        }

        public Principal(SqlConnection sqlCon)
            : this()
        {

            this.sqlCon = sqlCon;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //creo instancia de nueva ventana
            Login.frm_login frmLogin = new Login.frm_login(sqlCon);

            //llamo
            if (frmLogin.ShowDialog() == DialogResult.Yes)
            {


                usuario = frmLogin.GetUsuario();
                //activo menu
                activarMenuSegunRol(frmLogin.GetRolUsuario());


                //veo de activar pestaña cambio rol
                activarCambioRol();


            }
            else
            {

                this.Close();
            }

            //libero
            frmLogin.Dispose();
        }


        //FUNCIONES

        void activarMenuSegunRol(String rol)
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT FUNCIONALIDAD_NOMBRE FROM MISSINGNO.FUNC_ROL WHERE "; //MATCHEO POR FUNCIONALIDAD_NOMBRE, ES AL PEDO EL FUNC_ID AL IGUAL QUE EL ROL_ID
            cmd.CommandText += "ROL_NOMBRE = '" + rol + "'";
            cmd.Connection = sqlCon;

            //ejecuto
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    switch (reader.GetString(0))
                    {

                        case "ABM_rol": menu.Items[0].Enabled = true; break;

                        case "ABM_afiliado": menu.Items[1].Enabled = true; break;

                        case "ABM_profesional": menu.Items[2].Enabled = true; break;

                        case "ABM_especialidad": menu.Items[3].Enabled = true; break;

                        case "Registrar_agenda": menu.Items[4].Enabled = true; break;

                        case "Compra_bono": menu.Items[5].Enabled = true; break;

                        case "Pedir_turno": menu.Items[6].Enabled = true; break;

                        case "Registrar_llegada_atencion": menu.Items[7].Enabled = true; break;

                        case "Registrar_resultado_atencion": menu.Items[8].Enabled = true; break;

                        case "Cancelar_turno": menu.Items[9].Enabled = true; break;

                        case "Estadisticas": menu.Items[10].Enabled = true; break;





                        default: /*nada*/ break;
                    }
                }

                //guardo rol
                this.rol = rol;
            }
            else
            {
                //fallo
                MessageBox.Show("Error al leer el campo FUNCIONALIDAD_NOMBRE en la tabla FUNCIONALIDAD_DE_ROL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            //libero
            reader.Close();
            //libero
            cmd.Dispose();

            //Si no esta habilitado, le deshabilito los botones

            if (rol == "Administrativo")
            {
                if (!AdminHabilitado())
                {
                    menu.Items[0].Enabled = false;
                    menu.Items[1].Enabled = false;
                    menu.Items[7].Enabled = false;
                    menu.Items[11].Enabled = false;
                }
            }

            if (rol == "Profesional")
            {
                if (!ProfesionalHabilitado())
                {
                    menu.Items[8].Enabled = false;
                    menu.Items[9].Enabled = false;
                }
            }

            if (rol == "Afiliado")
            {
                if (!AfiliadoHabilitado())
                {
                    menu.Items[5].Enabled = false;
                    menu.Items[6].Enabled = false;
                    menu.Items[7].Enabled = false;
                }
            }


        }

        //Funcion para cambiar de rol una vez logeado(Hay que agregar el boton al menu)
        private void activarCambioRol()
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.ROL_DE_USUARIO WHERE ";
            cmd.CommandText += "USERNAME = '" + usuario + "'";
            cmd.Connection = sqlCon;

            //ejecuto
            if ((Int32)cmd.ExecuteScalar() > 1)
            {
                //activo pestaño menu

                menu.Items[11].Enabled = true;


            }

            //libero
            cmd.Dispose();
        }


        private bool AfiliadoHabilitado()
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.AFILIADO WHERE ";
            cmd.CommandText += "USERNAME = '" + usuario + "' ";
            cmd.CommandText += "AND AFILIADO_BAJA_LOGICA= 0";
            cmd.Connection = sqlCon;

            if ((Int32)cmd.ExecuteScalar() < 1)
            {
                cmd.Dispose();
                return false;
            }

            //libero
            cmd.Dispose();
            return true;
        }

        private bool ProfesionalHabilitado()
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.PROFESIONAL WHERE ";
            cmd.CommandText += "USERNAME = '" + usuario + "' ";
            cmd.CommandText += "AND PROFESIONAL_BAJA_LOGICA = 0";
            cmd.Connection = sqlCon;

            if ((Int32)cmd.ExecuteScalar() < 1)
            {
                cmd.Dispose();
                return false;
            }

            //libero
            cmd.Dispose();
            return true;
        }

        private bool AdminHabilitado()
        {
            //consula sql
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.ADMINISTRATIVO WHERE ";
            cmd.CommandText += "USERNAME = '" + usuario + "' ";
            cmd.CommandText += "AND ADMIN_BAJA_LOGICA = 0";
            cmd.Connection = sqlCon;

            if ((Int32)cmd.ExecuteScalar() < 1)
            {
                cmd.Dispose();
                return false;
            }

            //libero
            cmd.Dispose();
            return true;
        }


        //Lo que hace cada botoncito cuando le dan click

        private void aBMDeRolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
