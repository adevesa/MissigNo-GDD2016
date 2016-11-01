using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class AbmRegistroResultado : Form
    {
        BDComun conexion = new BDComun();

        public AbmRegistroResultado()
        {
            InitializeComponent();
        }

        public bool errores_de_consulta()  
        {
            return (textoConsulta.Text.Length == 0 || textoDiagnostico.Text.Length == 0 || textoSintoma.TextLength == 0 || (!opcionNo.Checked && !opcionSi.Checked));
        }

        public string check(){
            if (opcionSi.Checked) return "Si";
            else return "No";
        }


        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            if(!errores_de_consulta()){
                if(! (textoDiagnostico.TextLength >140)){
                    conexion.modificarConsulta(textoConsulta.Text, textoDiagnostico.Text, textoSintoma.Text);//, check());
            AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
            this.Hide();
            abmRolProfesional.ShowDialog();
            this.Close();
            }
                else MessageBox.Show("El diagnostico solo puede contener hasta 140 caracteres!");
            }
            else MessageBox.Show("Faltan completar datos");
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolProfesional abmRolProfesional = new AbmRol.AbmRolProfesional();
            this.Hide();
            abmRolProfesional.ShowDialog();
            this.Close();
        }

        private void AbmRegistroResultado_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MesDeBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textoConsulta_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
