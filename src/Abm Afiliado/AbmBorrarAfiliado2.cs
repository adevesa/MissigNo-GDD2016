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
    public partial class AbmBorrarAfiliado2 : Form
    {
        //Atributos//
        BDComun conexion = new BDComun();

        public AbmBorrarAfiliado2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textoUsername.Text.Length < 60) {
            if (conexion.existeUsuario(textoUsername.Text)) //verifico primero la existencia del usuario ingresado
            {
            conexion.borrarAfiliado(textoUsername.Text);
            MessageBox.Show("Afiliado borrado exitosamente");
            textoUsername.Clear();
                }
            else  MessageBox.Show("Usuario inexistente");
        }
            else MessageBox.Show("Username demaciado largo");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbmBorrarAfiliado2_Load(object sender, EventArgs e)
        {
        
        }
    }
}
