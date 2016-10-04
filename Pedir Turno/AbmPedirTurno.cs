using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class AbmPedirTurno : Form
    {
        public AbmPedirTurno()
        {
            InitializeComponent();
        }

        private void AbmPedirTurno_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            AbmElegirHorario abmElegirHorario = new AbmElegirHorario();
            this.Hide();
            abmElegirHorario.ShowDialog();
            this.Close();
        }
    }
}
