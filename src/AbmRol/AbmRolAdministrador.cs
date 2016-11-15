using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class AbmRolAdministrador : Form
    {
        public AbmRolAdministrador()
        {
            InitializeComponent();
        }

        private void AbmRolAdministrador_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            timer1.Enabled = true;

            Usuario.Text = "Administrador: " + Program.usuario;

            //Mostrar Fecha y Hora
            //Fecha.Text = DateTime.Now.ToLongDateString();
            Fecha.Text = Program.fecha.ToLongDateString();

            //Centrar Usuario
            Int32 anchoUsuario = (this.Width - Usuario.Width) / 2;
            Usuario.Location = new Point(anchoUsuario, Usuario.Location.Y);

            //Centrar Fecha
            Int32 anchoFecha = (this.Width - Fecha.Width) - 10;
            Fecha.Location = new Point(anchoFecha, Fecha.Location.Y);


        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Login.frm_login logueo = new ClinicaFrba.Login.frm_login();
            this.Hide();
            logueo.ShowDialog();
            this.Close();
        }

        private void botonModificarAfiliado_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Compra_Bono.ComprarBonoDesdeAdministrador abmComprarBono = new ClinicaFrba.Compra_Bono.ComprarBonoDesdeAdministrador();
            abmComprarBono.ShowDialog();
        }

        private void botonCrearAfiliado_Click(object sender, EventArgs e)
        {
            Abm_Afiliado.AbmAdministrarAfiliado abmAdministrarAfiliado = new Abm_Afiliado.AbmAdministrarAfiliado();
            this.Hide();
            abmAdministrarAfiliado.ShowDialog();
            this.Close();
        }

        private void botonRegistrarLlegada_Click(object sender, EventArgs e)
        {
            Registro_Llegada.RegistroDeLlegada abmRegistroDeLlegada = new Registro_Llegada.RegistroDeLlegada();
            this.Hide();
            abmRegistroDeLlegada.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;

        }

        private void botonTops_Click(object sender, EventArgs e)
        {
            Listados.AbmListados abmListado = new Listados.AbmListados();
            abmListado.ShowDialog();
        }
    }
}
