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

        string dia;

        public AbmElegirHorario(Palabra afi, Palabra esp)
        {
            this.especialidad = esp;
            this.profesional = afi;
            InitializeComponent();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            AbmRol.AbmRolAfiliado abmRolAfiliado = new AbmRol.AbmRolAfiliado();
            this.Hide();
            abmRolAfiliado.ShowDialog();
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
            dia = calendario.SelectionStart.DayOfWeek.ToString();
            int desde = conexion.desdeDia(profesional.unElemento, dia);
            int hasta = conexion.hastaDia(profesional.unElemento, dia);
            dgvHorarios.DataSource = calcularTurnos2(10, 20);

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


    }
}
