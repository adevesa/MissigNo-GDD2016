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
        public AbmCancelarTurnoProf()
        {
            InitializeComponent();
        }


          public bool errores_de_registro()
        {
            return ((textoMotivo.Text.Length == 0) || tipoCancelacion.Text == "Tipo de cancelación"); 

       }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
                        if (errores_de_registro())
                  {
                        MessageBox.Show("Faltan completar datos");
                  }
                        else this.Close();
                
                 
    }

        private void AbmCancelarTurnoProf_Load(object sender, EventArgs e)
        {
        
        }
}
}
