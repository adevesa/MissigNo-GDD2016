using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void Logueo_Load(object sender, EventArgs e)
        {   
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
     

            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 4;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Registro_Resultado.SeleccionDeRol seleccionDeRol = new ClinicaFrba.Registro_Resultado.SeleccionDeRol();
            this.Hide();
            seleccionDeRol.ShowDialog();
            this.Close();
        }
    }
}
