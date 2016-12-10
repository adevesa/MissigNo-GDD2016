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
    {   //Atributos//
        BDComun conexion = new BDComun();
        public string userPadre;
        public string direccionPadre;
        public List<AfiliadoSimple> listaFamiliares = new List<AfiliadoSimple>();
        public AfiliadoSimple familiarNuevo = new AfiliadoSimple();
        public string plan;
        

        public AgregarFamiliar(List<AfiliadoSimple> lista, string padre, string direccion)
        {
            this.listaFamiliares = lista;
           // this.abmPadre = abmConsulta;
            this.userPadre = padre;
            this.direccionPadre = direccion;
            InitializeComponent();
        }

        //Funcion para verificar que no haya ningun textbox vacio
        public bool errores_de_registro() 
        {
            return ((textoApellido.Text.Length == 0) || (textoNombre.Text.Length == 0) || textoTelefono.Text.Length == 0 || textoDocumento.Text.Length == 0 || eleccionSexo.Text.Length == 0 || fechaDeNacimiento.Text.Length == 0 || planMedico.Text == "Elija uno" || eleccionSexo.Text == "Sexo" || textoContraseña.Text.Length == 0 || textoEmail.Text.Length == 0 || textoTipoDocumento.Text.Length == 0 || textoUsername.Text.Length == 0);  
        }

        private void BotonConfirmar2_Click(object sender, EventArgs e)
        {
            //verifico no tener errores de registro
            if (errores_de_registro())
            {
                MessageBox.Show("Faltan completar datos");
                
            }
            else
            {//verifico que el username no exista
                if(!conexion.existeUsuario(textoUsername.Text))
                {
                    //verifico que el dni no este en uso
                     if(!conexion.dniEnUso(textoDocumento.Text)){
                int idAfiliado = conexion.obtenerAfiliadoId(this.userPadre);
                         //insert al familiar nuevo
                conexion.crearFamiliar(textoUsername.Text, textoTipoDocumento.Text, textoDocumento.Text, textoContraseña.Text, textoNombre.Text, textoApellido.Text, fechaDeNacimiento.Value, eleccionSexo.Text, this.direccionPadre, textoEmail.Text, textoTelefono.Text, estadoCivil.Text, planMedico.Text, idAfiliado);
                MessageBox.Show("FAMILIAR CREADO CON EXITO!");
                //guardo los datos de los textBox para meter en una lista y poder devolverselo al abmConsultaFamiliar 
                familiarNuevo.username = textoUsername.Text;
                familiarNuevo.nombre = textoNombre.Text;
                familiarNuevo.apellido = textoApellido.Text;
                listaFamiliares.Add(familiarNuevo);
                ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar abm = new ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar(listaFamiliares, userPadre, direccionPadre);
                    this.Hide();
                    abm.ShowDialog();
                    this.Close();
                     }
                     else MessageBox.Show("Nº de DNI en uso");
                } 
                else MessageBox.Show("Username en uso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar abm = new ClinicaFrba.Abm_Afiliado.AbmConsultaFamiliar(listaFamiliares, userPadre, direccionPadre);
            this.Hide();
            abm.ShowDialog();
            this.Close();
        }

        private void AgregarFamiliar_Load(object sender, EventArgs e)
        {
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            conexion.recuperarPlanes(planMedico, plan);
        }


        //Funciones para asegurar que solo se pueda escribir numeros en los textBox de telefono y dni
        private void textoTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textoDocumento_KeyPress_1(object sender, KeyPressEventArgs e)
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
