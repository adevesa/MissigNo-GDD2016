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
    public partial class AbmElegirHorario : Form
    {
        BDComun conexion = new BDComun();
        Palabra especialidad = new Palabra();
        Palabra profesional = new Palabra();
        List<int> listaDeHorarios = new List<int>();
     //   Time horarioElegido = new Time();
        TimeSpan horarioElegido = new TimeSpan();
        int bonoId = new int();
        string dia;
        DateTime fecha = new DateTime();

        public AbmElegirHorario(Palabra prof, Palabra esp, int bonoId)
        {
            this.bonoId = bonoId;
            this.especialidad = esp;
            this.profesional = prof;
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            int idTurno = conexion.crearTurno(profesional.unElemento, bonoId, fecha, horarioElegido);
            MessageBox.Show("Su número de turno es: " + idTurno);
            AbmRol.AbmRolAfiliado abmRolAfiliado = new AbmRol.AbmRolAfiliado();
            //this.Hide();
            //abmRolAfiliado.ShowDialog();
            this.Close();
        }

        private void AbmElegirHorario_Load(object sender, EventArgs e)
        {
            //Centra los componentes, adaptandose al tamaño del monitor//
            Size resolucionPantalla = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;

            //Centrar Panel
            Int32 anchoDePanel = (this.Width - panel1.Width) / 2;
            Int32 largoDePanel = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(anchoDePanel, largoDePanel);
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
           // AbmPedirTurno abmPedirTurno = new AbmPedirTurno();
           // this.Hide();
           // abmPedirTurno.ShowDialog();
            this.Close();
        }

        private void listaDeHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BotonFiltrar_Click(object sender, EventArgs e)
        {

            //conexion.turnosEnFecha(Convert.ToDateTime("02-11-2016"), "faustino_Gallardo@gmail.com", "Angiología y Cirugía Vascular");
           fecha = calendario.SelectionStart.Date;
           List<TimeSpan> horariosUsados = conexion.horariosUsados(fecha, this.profesional.unElemento);
           List<TimeSpan> horariosTotales = conexion.turnosEnFecha(fecha, this.profesional.unElemento, this.especialidad.unElemento);

           //dgvHorarios.DataSource = convertirEnTime(horariosTotales);
           dgvHorarios.DataSource = convertirEnTime(filtrarHorarios(horariosUsados, horariosTotales));
           


        }

        public List<TimeSpan> filtrarHorarios(List<TimeSpan> horariosUsados, List<TimeSpan> horariosTotales)
        {
            List<TimeSpan> horariosFiltrados = new List<TimeSpan>();
            int cantidad = horariosTotales.Count();
            for(int i = 0; cantidad>i ; i++)
            {
                TimeSpan horario = horariosTotales[i];
                if (!horariosUsados.Exists(x => x == horario))
                {
                    horariosFiltrados.Add(horario);
                }
            }
            return horariosFiltrados;
        }


        
        public List<Time> convertirEnTime(List<TimeSpan> timeSpan){
            List<Time> horarios = new List<Time>();
            int tamaño = timeSpan.Count;
            for(int i = 0; tamaño > i; i++){
                Time horario = new Time();
                horario.hora = Convert.ToInt32(timeSpan[i].Hours);
                horario.minuto = Convert.ToInt32(timeSpan[i].Minutes);
                horarios.Add(horario);
            }
            return horarios;
        }
        

        public List<int> calcularTurnos(int desde, int hasta)
        {
        List<int> lista = new List<int>();
        int i;
        for(i = desde; hasta>i; i++){
            lista.Add(i);
            }
        return lista;
        }


        public List<Palabra> calcularTurnos2(int desde, int hasta)
        {
            List<Palabra> lista = new List<Palabra>();
            int i;
            for (i = desde; hasta > i; i++)
            {
                Palabra horario = new Palabra();
                string D = Convert.ToString(i);
                string H = Convert.ToString(i+1);
                horario.unElemento = "desde: " + D + "hs, hasta: " + H + "hs";
                lista.Add(horario);
            }
            return lista;
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvHorarios.CurrentRow.Index;
            horarioElegido = new TimeSpan(Convert.ToInt32(dgvHorarios[0, posicion].Value), Convert.ToInt32(dgvHorarios[1, posicion].Value), 0);
           // MessageBox.Show("horario: " + horarioElegido);
        }


    }
}
