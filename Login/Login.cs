using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Configuration;

namespace ClinicaFrba.Login
{
    public partial class frm_login : Form
    {

        private int intentos = 0;

        private bool existeUsr = false;

        private String usrString = null;

        private String usrRol = null;

        BDComun conexion = new BDComun();

        public frm_login()
        {
            InitializeComponent();
        }

        private void textBox_usr_TextChanged(object sender, EventArgs e)
        {
            error_text1.Clear();
        }

        private void textBox_psw_TextChanged(object sender, EventArgs e)
        {
            error_text2.Clear();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = existeUsr && usrRol != null ? DialogResult.Yes : DialogResult.No;
        }


        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            ClinicaFrba.Program.setUsuario(textBox_usr.Text);

            bool vacio = false;

           
            if (textBox_usr.Text.Length == 0)
            {
                error_text1.SetError(textBox_usr, "Por favor escriba el nombre de usuario.");
                vacio = true;
            }

            if (textBox_psw.Text.Length == 0)
            {
                error_text2.SetError(textBox_psw, "Por favor escriba la contraseña.");
                vacio = true;
            }
            
            if (vacio) return;


            if (conexion.existeUsuario(textBox_usr.Text))
                {
                    if (intentos <= 3)
                    {
                        if (conexion.contraseñaCorrecta(textBox_usr.Text, textBox_psw.Text))
                        {
                        intentos = 0;
                        ClinicaFrba.Login.SeleccionRol seleccionRol = new ClinicaFrba.Login.SeleccionRol(textBox_usr.Text);
                        this.Hide();
                        seleccionRol.ShowDialog();
                        this.Close();
                        }
                        else
                        { 
                            intentos++;
                            MessageBox.Show("Los datos no coinciden");
                        }
                    } 
                   
                else MessageBox.Show("Vuelva a intentarlo más tarde");
                }
            else MessageBox.Show("Usuario inexistente");
            
              }

            
            
        

        private void textBox_psw_Enter(object sender, EventArgs e)
        {
            //apretar enter en el textobox contraseña equivale a hacer clilc en ingresar
            ActiveForm.AcceptButton = btn_ingresar;
        }

        public String GetUsuario()
        {
            return usrString;
        }

        public String GetRolUsuario()
        {
            return usrRol;
        }


        private void frm_login_Load(object sender, EventArgs e)
        {
            intentos = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
