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
        Palabra especialidad = new Palabra();
        string afiliadoUsername;
       
        public cargarTurnos(Palabra profesional, string afiliado, Palabra especialidad)
        {
            this.especialidad = especialidad;
            this.profesional = profesional;
            this.afiliadoUsername = afiliado;
            InitializeComponent();
        }

        private void cargarTurnos_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;


            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
            unTurno.idTurno = -1;
            turnos = conexion.obtenerTurnos(profesional.unElemento, afiliadoUsername);
            dgvTurnos.DataSource = turnos;
            conexion.bonosDeAfiliado(afiliadoUsername, bono);
            if (dgvTurnos.RowCount == 0)                // DETECTAR SI LA DGV ESTA VACÍA...
            {
                MessageBox.Show("No hay turnos asociados a ese profesional");
                this.Hide();
                AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
                abmRolAdministrador.ShowDialog();
                this.Close();
            }

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {


            if (unTurno.idTurno != -1)
            {
            int bonoId = Convert.ToInt32(bono.Text);
            conexion.generarConsulta(bonoId, especialidad.unElemento, profesional.unElemento, unTurno.idTurno);
            AbmRol.AbmRolAdministrador abmRolAdministrador = new AbmRol.AbmRolAdministrador();
            MessageBox.Show("Consulta creada correctamente");
            this.Hide();
            abmRolAdministrador.ShowDialog();
            this.Close();
            }
            else MessageBox.Show("Primero elija un turno");
            
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvTurnos.CurrentRow.Index;
            unTurno.idTurno = Convert.ToInt32(dgvTurnos[0, posicion].Value);
            unTurno.fechaTurno = Convert.ToDateTime(dgvTurnos[1, posicion].Value);
            
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
