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
    public partial class AbmCancelarTurnoProf : Form
    {
        BDComun conexion = new BDComun();
        private String username;
        int indicador = new int();

        public AbmCancelarTurnoProf()
        {
            this.username = Program.usuario;
            InitializeComponent();
        }

        public bool errores_de_registro()
        {
            return ((textoMotivo.Text.Length == 0) || tipoCancelacion.Text.Length == 0 || textoMotivo.Text == "Escriba el motivo...");

        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {

            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
            }
            else
            {
                if (dateTimeDesde.Value > dateTimeHasta.Value)
                {
                    MessageBox.Show("Error en las fechas");
                }
                else
                {
                    conexion.cancelarDias(username, dateTimeDesde.Value, dateTimeHasta.Value, tipoCancelacion.Text, textoMotivo.Text);
                }
            this.Close();
            }
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tipoCancelacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
