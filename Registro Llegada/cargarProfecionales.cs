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
    public partial class cargarProfecionales : Form
    {   
        BDComun conexion = new BDComun();
        List<Palabra> profecionales = new List<Palabra>();
        Palabra especialidad = new Palabra();
        string afiliadoUsername;
        public cargarProfecionales(Palabra especialidad, string username)
        {
            this.especialidad = especialidad;
            this.afiliadoUsername = username;
        
            InitializeComponent();
        }

        private void cargarProfecionales_Load(object sender, EventArgs e)
        {
           //profecionales = conexion.obtenerProfesionalesPorEspecialidad(especialidad.unElemento);
          //  dgvProfecionales.DataSource = profecionales;
        }
    }
}
