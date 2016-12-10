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
    {   //Atributos//
        BDComun conexion = new BDComun();
        private String username;
        int indicador = new int();

        public AbmCancelarTurnoProf()
        {
            this.username = Program.usuario;
            InitializeComponent();
            dateTimeDesde.Value = Program.fecha;
            dateTimeHasta.Value = Program.fecha.AddDays(1);
        }

        public bool errores_de_registro()//Funcion para verificar que no haya textBox vacios
        {
            return ((textoMotivo.Text.Length == 0) || tipoCancelacion.Text.Length == 0 || textoMotivo.Text == "Escriba el motivo...");

        }

        public bool errores_de_exceso()
        {
            return ((textoMotivo.Text.Length < 140) && tipoCancelacion.Text.Length < 20);

        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            //Verifica que esten todos los campos completos
            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
            }
            else
            {       //verifica que la fecha de hasta no sea menor que la de desde
                if (dateTimeDesde.Value > dateTimeHasta.Value)
                {
                    MessageBox.Show("Error en las fechas");
                }
                else
                {
                    conexion.cancelarDias(username, dateTimeDesde.Value, dateTimeHasta.Value, tipoCancelacion.Text, textoMotivo.Text);
                    this.Close();
                }

            }
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tipoCancelacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbmCancelarTurnoProf_Load(object sender, EventArgs e)
        {

        }

        private void botonConfirmar_Click_1(object sender, EventArgs e)
        {
            if (errores_de_exceso()){
            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
            }
            else
            {       //verifica que la fecha de hasta no sea menor que la de desde
                if (dateTimeDesde.Value > dateTimeHasta.Value)
                {
                    MessageBox.Show("Error en las fechas");
                }
                else
                {
                    conexion.cancelarDias(username, dateTimeDesde.Value, dateTimeHasta.Value, tipoCancelacion.Text, textoMotivo.Text);
                    MessageBox.Show("FECHAS CANCELADAS");
                    this.Close();
                }

            }

            }
            else MessageBox.Show("Se sobrepasò el maximo de caracteres");
         }
           
    }
}
