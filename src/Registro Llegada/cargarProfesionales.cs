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
        List<Palabra> profesionales = new List<Palabra>();
        List<Palabra> profesionalesFiltrados = new List<Palabra>();
        Palabra especialidad = new Palabra();
        Palabra profesional = new Palabra();
        int indicador;
        string afiliadoUsername;
        public cargarProfesionales(Palabra especialidad, string username, int indicador)
        {
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

             
        
           profesionales = conexion.obtenerProfesionalesPorEspecialidad(especialidad.unElemento);
            int i;
            int tamaño = profesionales.Count;
            for(i=0; tamaño>i; i++){
                Palabra profesional = profesionales[i];
                int num = conexion.tieneAgenda(profesional.unElemento ,especialidad.unElemento);
                if(num ==1){
                    profesionalesFiltrados.Add(profesional);
                }
                }

              dgvProfesionales.DataSource = profesionalesFiltrados;

              if (profesionalesFiltrados.Count == 0){
                  MessageBox.Show("Lo sentimos, ningún profesional ha creado una agenda con esta especialidad");
              }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
           if(!(profesional.unElemento == null))
           {
           //if(conexion.tieneAgenda(profesional.unElemento, especialidad.unElemento))
          // {
            if(indicador == 0)
            {
            cargarTurnos abm = new cargarTurnos(profesional, afiliadoUsername, especialidad);

            this.Hide();
            abm.ShowDialog();
            this.Close();
            }
            else
            {
                ClinicaFrba.Cancelar_Atencion.AbmElegirHorario abm = new ClinicaFrba.Cancelar_Atencion.AbmElegirHorario(profesional, especialidad);
                this.Hide();
                abm.ShowDialog();
                this.Close();
            }
           //}
          // else MessageBox.Show("Lo sentimos, el profesional todavia no a registrado una agenda para esta especialidad");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             if(indicador == 0)
             {
                 RegistroDeLlegada abm = new RegistroDeLlegada();

                 this.Hide();
                 abm.ShowDialog();
                 this.Close();
             }
             else
             {
                 ClinicaFrba.Cancelar_Atencion.AbmPedirTurno abm = new ClinicaFrba.Cancelar_Atencion.AbmPedirTurno();
                 this.Hide();
                 abm.ShowDialog();
                 this.Close();
             }
        }
    }
}
