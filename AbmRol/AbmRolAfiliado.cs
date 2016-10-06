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
    public partial class AbmRolAfiliado : Form
    {
        public AbmRolAfiliado()
        {
            InitializeComponent();
        }

        private void AbmRolAfiliado_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);


            timer1.Enabled = true;

            Usuario.Text = "Afiliado: " + Program.usuario;

            //Mostrar Fecha y Hora
            Fecha.Text = DateTime.Now.ToLongDateString();

            //Centrar Usuario
            Int32 anchoUsuario = (this.Width - Usuario.Width) / 2;
            Usuario.Location = new Point(anchoUsuario, Usuario.Location.Y);

            //Centrar Fecha
            Int32 anchoFecha = (this.Width - Fecha.Width) - 10;
            Fecha.Location = new Point(anchoFecha, Fecha.Location.Y);


        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Logueo logueo = new Logueo();
            this.Hide();
            logueo.ShowDialog();
            this.Close();
        }

        private void botonCancelarTurno_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Pedir_Turno.AbmCancelarTurno abmCancelarTurno = new ClinicaFrba.Pedir_Turno.AbmCancelarTurno();
            abmCancelarTurno.ShowDialog();

        }

        private void botonModificarAfiliado_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Compra_Bono.AbmComprarBono abmComprarBono = new ClinicaFrba.Compra_Bono.AbmComprarBono();
            abmComprarBono.ShowDialog();
        }

        private void botonPedirTurno_Click(object sender, EventArgs e)
        {
            Pedir_Turno.AbmPedirTurno abmPedirTurno = new Pedir_Turno.AbmPedirTurno();
            abmPedirTurno.ShowDialog();
        }

        private void Hora_Click(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
