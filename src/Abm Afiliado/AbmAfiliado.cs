using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AbmAdministrarAfiliado : Form
    {
        public AbmAdministrarAfiliado()
        {
            InitializeComponent();
        }

        private void AbmAfiliado_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void botonCrearAfiliado_Click(object sender, EventArgs e)
        {
            AbmCrearAfiliado abmCrearAfiliado = new AbmCrearAfiliado();
            this.Hide();
            abmCrearAfiliado.ShowDialog();
            this.Close();
        }

        private void botonModificarAfiliado_Click(object sender, EventArgs e)
        {
            AbmCrearAfiliado2 abmEditarAfiliado = new AbmCrearAfiliado2();
            this.Hide();
            abmEditarAfiliado.ShowDialog();
            this.Close();
        }

        private void botonBorrarAfiliado_Click(object sender, EventArgs e)
        {
            AbmBorrarAfiliado2 abmBorrarAfiliado = new AbmBorrarAfiliado2();

            abmBorrarAfiliado.ShowDialog();

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
            this.Hide();
            abmRolAdministrador.ShowDialog();
            this.Close();
        }

        private void historialAfiliado_Click(object sender, EventArgs e)
        {
            HistorialAfiliado histAfiliado = new HistorialAfiliado();
            histAfiliado.ShowDialog();
        }
    }
}
