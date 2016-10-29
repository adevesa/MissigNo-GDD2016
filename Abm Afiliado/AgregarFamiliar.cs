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
    public partial class AgregarFamiliar : Form
    {
        public string userPadre;
        public string direccionPadre;
        public List<AfiliadoSimple> listaFamiliares;
        
        public AgregarFamiliar()
        {
            InitializeComponent();
        }

        public bool errores_de_registro()
        {
            return ((textoApellido.Text.Length == 0) || (textoNombre.Text.Length == 0) || textoTelefono.Text.Length == 0 || textoDocumento.Text.Length == 0 || eleccionSexo.Text.Length == 0 || fechaDeNacimiento.Text.Length == 0 || planMedico.Text == "Elija uno" || eleccionSexo.Text == "Sexo" || textoContraseña.Text.Length == 0 || textoEmail.Text.Length == 0 || textoTipoDocumento.Text.Length == 0 || textoUsername.Text.Length == 0);  
        }

        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {

            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
            }
            else
            {
                UsuarioDAL.crearAfiliado(textoUsername.Text, textoTipoDocumento.Text, textoDocumento.Text, textoContraseña.Text, textoNombre.Text, textoApellido.Text, fechaDeNacimiento.Value, eleccionSexo.Text, this.direccionPadre, textoEmail.Text, textoTelefono.Text, estadoCivil.Text, planMedico.Text, this.userPadre);
                AbmConsultaFamiliar abmConsulta = new AbmConsultaFamiliar();
                this.listaFamiliares.Add(UsuarioDAL.Buscar_afiliado_por_username(textoUsername.Text));
                abmConsulta.listaFamiliares = this.listaFamiliares;
                this.Hide();
                abmConsulta.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmConsultaFamiliar abmConsulta = new AbmConsultaFamiliar();
            this.Hide();
            abmConsulta.ShowDialog();
            this.Close();
        }

        private void AgregarFamiliar_Load(object sender, EventArgs e)
        {

        }


    }
}
