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
    public partial class AbmPedirTurno : Form
    {
        BDComun conexion = new BDComun();
        List<Palabra> listaEspecialidades = new List<Palabra>();
        Palabra especialidad = new Palabra();

        public AbmPedirTurno()
        {

            InitializeComponent();
        }

        private void AbmPedirTurno_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

            listaEspecialidades = conexion.obtenerTodasLasEspecialidades();
            dgvEspecialidades.DataSource = listaEspecialidades;
            conexion.bonosDeAfiliado(Program.usuario, bono);

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
 
            ClinicaFrba.Registro_Llegada.cargarProfesionales abm = new ClinicaFrba.Registro_Llegada.cargarProfesionales(especialidad, Program.usuario, Convert.ToInt32(bono.Text), 1);
            this.Hide();
            abm.ShowDialog();
            this.Close();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolAfiliado abmRolAfiliado = new AbmRol.AbmRolAfiliado();
            this.Hide();
            abmRolAfiliado.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvEspecialidades.CurrentRow.Index;
            especialidad.unElemento = Convert.ToString(dgvEspecialidades[0, posicion].Value);
        }
    }
}
