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
        string afiliadoUsername;
        public cargarProfesionales(Palabra especialidad, string username)
        {
            this.especialidad = especialidad;
            this.afiliadoUsername = username;
        
            InitializeComponent();
        }

        private void cargarProfecionales_Load(object sender, EventArgs e)
        {
           profecionales = conexion.obtenerProfesionalesPorEspecialidad(especialidad.unElemento);
            dgvProfesionales.DataSource = profecionales;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            cargarTurnos abm = new cargarTurnos(profesional, afiliadoUsername);
            this.Hide();
            abm.ShowDialog();
            this.Close();
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
