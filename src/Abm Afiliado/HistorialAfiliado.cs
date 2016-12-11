using ClinicaFrba.Clases;
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
        List<tipoHistorial> historial = new List<tipoHistorial>();

        public HistorialAfiliado()
        {
            InitializeComponent();
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            if (textoUsername.Text.Length < 60)
            {
                if (!conexion.esAfiliado(textoUsername.Text))
                {
                    MessageBox.Show("No existe afiliado con ese username");
                }
                else
                {
                    int afiliadoId = conexion.obtenerAfiliadoId(textoUsername.Text);
                    historial = conexion.obtenerHistorialAfiliado(afiliadoId);
                    dgvAfiliadoHistorial.DataSource = historial;
                }
            }
            else
            {
                MessageBox.Show("Username demasiado largo");
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmAdministrarAfiliado abmAfiliado = new AbmAdministrarAfiliado();
            this.Hide();
            abmAfiliado.ShowDialog();
            this.Close();
        }

        private void textoUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistorialAfiliado_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }
    }
}
