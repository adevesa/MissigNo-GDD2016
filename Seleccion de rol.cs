using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class SeleccionDeRol : Form
    {
        public SeleccionDeRol()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (rol.Text == "Afiliado")  {
                AbmRol.AbmRolAfiliado abmRolAfiliado = new AbmRol.AbmRolAfiliado();
                this.Hide();
                abmRolAfiliado.ShowDialog();
                this.Close();
           }
            else {
                if (rol.Text == "Profesional"){
                    AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
                    this.Hide();
                    abmRolProfesional.ShowDialog();
                    this.Close();
                     }
                else{
                        if(rol.Text == "Administrador"){
                    AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
                    this.Hide();
                    abmRolAdministrador.ShowDialog();
                    this.Close();
                    }
                        else{
                            MessageBox.Show("Rol invalido");
                        }
                }
            }
        }
        private void seleccionDeRol_Load(object sender, EventArgs e)
        {
            
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
