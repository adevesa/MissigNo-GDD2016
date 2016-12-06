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
    public partial class HistorialAfiliado : Form
    {
        BDComun conexion = new BDComun();

        public HistorialAfiliado()
        {
            InitializeComponent();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (!conexion.esAfiliado(textoUsername.Text))
            {
                MessageBox.Show("No existe afiliado con ese username");
            }
            else
            {
                //RELLENAR DATAGRID
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textoUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
