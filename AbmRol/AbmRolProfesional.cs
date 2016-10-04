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
    public partial class AbmRolProfesional : Form
    {
        public AbmRolProfesional()
        {
            InitializeComponent();
        }

        private void AbmRolProfesional_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            Logueo logueo = new Logueo();
            this.Hide();
            logueo.ShowDialog();
            this.Close();
        }

        private void botonCrearAfiliado_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Pedir_Turno.AbmCancelarTurno abmCancelarTurno = new ClinicaFrba.Pedir_Turno.AbmCancelarTurno();
            abmCancelarTurno.ShowDialog();
        }

        private void botonRegistrarResultados_Click(object sender, EventArgs e)
        {
            Registro_Resultado.AbmRegistroResultado abmRegistroResultado = new Registro_Resultado.AbmRegistroResultado();
            this.Hide();
            abmRegistroResultado.ShowDialog();
            this.Close();
        }

        private void botonCrearAgenda_Click(object sender, EventArgs e)
        {
            Registrar_Agenta_Medico.AbmAgenda abmAgenda = new Registrar_Agenta_Medico.AbmAgenda();
            this.Hide();
            abmAgenda.ShowDialog();
            this.Close();
        }
    }
}
