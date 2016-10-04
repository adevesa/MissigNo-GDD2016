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
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            Logueo logueo = new Logueo();
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
    }
}
