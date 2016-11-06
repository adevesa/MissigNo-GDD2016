using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class AbmCancelarTurno : Form
    {   //Atributos//
        BDComun conexion = new BDComun();
        private String username;
        int indicador = new int();

         public AbmCancelarTurno(int indicador)
        {
            this.indicador = indicador;
            this.username = Program.usuario;
            InitializeComponent();
        }

         //Funcion para verificar que no haya textBox vacios
          public bool errores_de_registro()
        {
            return ((textoIDTurno.Text.Length == 0) || (textoMotivo.Text.Length == 0) || tipoCancelacion.Text.Length == 0 || textoMotivo.Text == "Escriba el motivo..."); 

       }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Turno_Load(object sender, EventArgs e)
        {   //Carga todos los turnos sin usar del afiliado
            conexion.turnosSinUsarAfi(Program.usuario, textoIDTurno);
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {

            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
            }
            else
            {
                if (conexion.turnoYaCancelado(Convert.ToInt32(textoIDTurno.Text)))
                {
                    MessageBox.Show("Ya esta cancelado el turno");
                }
                else
                {
                    conexion.cancelarTurno(Convert.ToInt32(textoIDTurno.Text), textoMotivo.Text, tipoCancelacion.Text);
                    MessageBox.Show("Consulta eliminada con éxito");
                }
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textoIDTurno_TextChanged(object sender, EventArgs e)
        {
            //error_text2.Clear();
        }

        private void textoIDTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tipoCancelacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
