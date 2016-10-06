using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class AbmAgenda : Form
    {
        public AbmAgenda()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DiaDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void MesDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void AnioDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AbmAgenda_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
            this.Hide();
            abmRolProfesional.ShowDialog();
            this.Close();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
            this.Hide();
            abmRolProfesional.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
