using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Login
{
    public partial class SeleccionRol : Form
    {
        private String rol;
        private String usr;
        BDComun conexion = new BDComun();

        public SeleccionRol(string username)
        {
            this.usr = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roles.Text == "Afiliado")
            {
                AbmRol.AbmRolAfiliado abmRolAfiliado = new AbmRol.AbmRolAfiliado();
                this.Hide();
                abmRolAfiliado.ShowDialog();
                this.Close();
            }
            else
            {
                if (roles.Text == "Profesional")
                {
                    AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
                    this.Hide();
                    abmRolProfesional.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (roles.Text == "Administrativo")
                    {
                        AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
                        this.Hide();
                        abmRolAdministrador.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Rol invalido");
                    }
                }
            }
        }
        /*
        private bool clienteEliminado()
        {
            //consula
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.USUARIO ";
            cmd.CommandText += "WHERE USERNAME = '" + usr + "' AND ";
            cmd.CommandText += "USUARIO_BAJA_LOGICA = 0"; // NO SE COMO LE PUSIERON A ESTE CAMPO PARA EL USUARIO. CAMBIARLO EN CASO DE QUE NO SEA BAJA_LOGICA.



            if ((Int32)cmd.ExecuteScalar() > 0)
            {
                //libero
                cmd.Dispose();
                return false;
            }

            //aviso que el cliente esta eliminado
            MessageBox.Show("Cliente eliminado del sistema o no dado de alta por el administrador.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //libero
            cmd.Dispose();
            return true;
        }
        */
        public String getRol()
        {
            return rol;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionRol_Load_1(object sender, EventArgs e)
        {
            conexion.recuperarRolesHabilitados(usr, roles, rol);
        }
    }
}
