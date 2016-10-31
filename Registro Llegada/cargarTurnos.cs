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
    public partial class cargarTurnos : Form
    {
        BDComun conexion = new BDComun();
        List<tipoTurno> turnos = new List<tipoTurno>();
        tipoTurno unTurno = new tipoTurno();
        //Palabra especialidad = new Palabra();
        Palabra profesional = new Palabra();
        string afiliadoUsername;
        public cargarTurnos(Palabra profesional, string afiliado)
        {
            this.profesional = profesional;
            this.afiliadoUsername = afiliado;
            InitializeComponent();
        }

        private void cargarTurnos_Load(object sender, EventArgs e)
        {
            turnos = conexion.obtenerTurnos(profesional.unElemento, afiliadoUsername);
            dgvTurnos.DataSource = turnos;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            conexion.generarConsulta(afiliadoUsername, profesional.unElemento, unTurno.idTurno, unTurno.fechaTurno);
            this.Close();
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvTurnos.CurrentRow.Index;
            unTurno.idTurno = Convert.ToInt32(dgvTurnos[0, posicion].Value);
            unTurno.fechaTurno = Convert.ToDateTime(dgvTurnos[1, posicion].Value);
        }
    }
}
