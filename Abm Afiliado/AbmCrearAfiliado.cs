using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AbmCrearAfiliado : Form
    {

        BDComun conexion = new BDComun();

        String plan;

        public AbmCrearAfiliado()
        {
            InitializeComponent();
        }


        private void AbmAfiliado_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            conexion.recuperarPlanes(planMedico, plan);

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmAdministrarAfiliado abmAfiliado = new AbmAdministrarAfiliado();
            this.Hide();
            abmAfiliado.ShowDialog();
            this.Close();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         public bool errores_de_registro()
        {
            return ((textoApellido.Text.Length == 0) || (textoNombre.Text.Length == 0) || textoDireccion.Text.Length == 0 || textoTelefono.Text.Length == 0 || textoDocumento.Text.Length == 0 || eleccionSexo.Text.Length == 0 || fechaDeNacimiento.Text.Length == 0 || planMedico.Text == "Elija uno" || eleccionSexo.Text == "Sexo" || textoContraseña.Text.Length == 0 || textoEmail.Text.Length == 0 || textoTipoDocumento.Text.Length ==0 || textoUsername.Text.Length == 0); 

       }
         private void botonConfirmar_Click(object sender, EventArgs e)
         {
             if (errores_de_registro())
             {
                 MessageBox.Show("Faltan completar datos");
             }
              else
             {
                 if(!conexion.existeUsuario(textoUsername.Text))
                {
                List<AfiliadoSimple> lista = new List<AfiliadoSimple>();
                  //  List<string> lista = new List<string>();
              conexion.crearAfiliado(textoUsername.Text, textoTipoDocumento.Text, textoDocumento.Text, textoContraseña.Text, textoNombre.Text, textoApellido.Text, fechaDeNacimiento.Value, eleccionSexo.Text, textoDireccion.Text, textoEmail.Text, textoTelefono.Text, estadoCivil.Text, planMedico.Text);
              AbmConsultaFamiliar abmConsulta = new AbmConsultaFamiliar(lista, textoUsername.Text,textoDireccion.Text);
              this.Hide();
              abmConsulta.ShowDialog();
              this.Close();
              }
                 else MessageBox.Show("Username en uso");
            }
         }
   
         private void fechaDeNacimiento_ValueChanged(object sender, EventArgs e)
         {

         }

    }
}