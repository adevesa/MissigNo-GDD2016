using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{   
    public partial class cargarProfesionales : Form
    {   
        BDComun conexion = new BDComun();
        List<Palabra> profecionales = new List<Palabra>();
        Palabra especialidad = new Palabra();
        Palabra profesional = new Palabra();
        int bonoId = new int();
        int indicador;
        string afiliadoUsername;
        public cargarProfesionales(Palabra especialidad, string username, int bonoid, int indicador)
        {
            this.bonoId = bonoid;
            this.especialidad = especialidad;
            this.afiliadoUsername = username;
            this.indicador = indicador;
        
            InitializeComponent();
        }

        private void cargarProfecionales_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);

           profecionales = conexion.obtenerProfesionalesPorEspecialidad(especialidad.unElemento);
            dgvProfesionales.DataSource = profecionales;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
           if(profesional.unElemento.Length != 0){
            if(indicador == 0)
            {
            cargarTurnos abm = new cargarTurnos(profesional, afiliadoUsername, especialidad);

            this.Hide();
            abm.ShowDialog();
            this.Close();
            }
            else
            {
                ClinicaFrba.Cancelar_Atencion.AbmElegirHorario abm = new ClinicaFrba.Cancelar_Atencion.AbmElegirHorario(profesional, especialidad, bonoId);

                this.Hide();
                abm.ShowDialog();
                this.Close();
            }
           }
           else MessageBox.Show("Debe elegir un profesional");

        }

        private void dgvProfecionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProfecionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvProfesionales.CurrentRow.Index;
            profesional.unElemento = Convert.ToString(dgvProfesionales[0, posicion].Value);
        }
    }
}
