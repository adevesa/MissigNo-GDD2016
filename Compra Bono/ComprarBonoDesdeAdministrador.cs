using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class ComprarBonoDesdeAdministrador : Form
    {
        BDComun conexion = new BDComun();
        private String username;
        public ComprarBonoDesdeAdministrador()
        {
            this.username = Program.usuario;
            InitializeComponent();
        }

        private void textoCantidadesDeBonos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            if (errores_de_registro())
            {
                MessageBox.Show("Datos incorrectos");
            }
            else 
            {
                if(conexion.existeUsuario(boxUserAfiliado.Text) && conexion.esAfiliado(boxUserAfiliado.Text))
                {
                conexion.comprarBonos(Convert.ToInt32(textoCantidadDeBonos.Text), boxUserAfiliado.Text);
                this.Hide();
                }
                else
                {
                    MessageBox.Show("No existe ese usuario o no es afiliado");
                }
            }
        }

        public bool errores_de_registro()
        {
            return ((textoCantidadDeBonos.Text.Length == 0) || Convert.ToInt32(textoCantidadDeBonos.Text) <= 0 || (boxUserAfiliado.Text.Length == 0));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoCantidadDeBonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClinicaFrba.AbmRol.AbmRolAdministrador adminpantalla = new ClinicaFrba.AbmRol.AbmRolAdministrador();
            this.Hide();
            adminpantalla.ShowDialog();
            this.Close();
        }

        private void ComprarBonoDesdeAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}
