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
        private SqlConnection sqlCon = null;

        private String rol = null;

        private String usr = null;

        public SeleccionRol(string username)
        {
            this.usr = username;
            InitializeComponent();
        }
        private bool recuperarRolesHabilitados()
        {
            //consula
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT MISSINGNO.ROL_DE_USUARIO.ROL_NOMBRE FROM MISSINGNO.ROL_DE_USUARIO ";
            cmd.CommandText += "JOIN MISSINGNO.ROL ON (MISSINGNO.ROL.ROL_NOMBRE = MISSINGNO.ROL_DE_USUARIO.ROL_NOMBRE AND ROL_HABILITADO = 1) WHERE ";
            cmd.CommandText += "MISSINGNO.ROL_DE_USUARIO.USERNAME = '" + usr + "'";
            cmd.Connection = sqlCon;

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

                //libero
                reader.Close();
                //libero
                cmd.Dispose();

                return true;
            }

            //fallo
            MessageBox.Show("El usuario no tiene ningun rol habilitado para mostrar.", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //libero
            reader.Close();
            //libero
            cmd.Dispose();
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rol = roles.GetItemText(roles.SelectedItem);

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private bool clienteEliminado()
        {
            //consula
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT COUNT(*) FROM MISSINGNO.USUARIO ";
            cmd.CommandText += "WHERE USERNAME = '" + usr + "' AND ";
            cmd.CommandText += "USUARIO_BAJA_LOGICA = 0"; // NO SE COMO LE PUSIERON A ESTE CAMPO PARA EL USUARIO. CAMBIARLO EN CASO DE QUE NO SEA BAJA_LOGICA.

            cmd.Connection = sqlCon;

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

        public DialogResult _ShowDialog()
        {
            //recupero los roles para el usuario que estan habilitados
            if (recuperarRolesHabilitados())
            {
                if (rol != null)
                {
                    if (rol == "CLIENTE")
                    {
                        /* if (clienteEliminado())
                         {
                             return DialogResult.No;
                         }
                        */
                    }

                    //como solo tiene uno, no mostramos el cuadro de seleccion
                    return DialogResult.Yes;
                }
                else
                {
                    //mostramos el cuadro de seleccion
                    return this.ShowDialog();
                }
            }

            return DialogResult.No;
        }

        public String getRol()
        {
            return rol;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }

        private void SeleccionRol_Load_1(object sender, EventArgs e)
        {

        }
    }
}
