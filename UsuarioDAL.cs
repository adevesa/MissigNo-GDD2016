﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClinicaFrba
{
    class UsuarioDAL
    {


        public static string cifrarGenero(string genero)
        {
            if (genero == "Hombre")
            { return "H"; }
            else
            { return "M"; }
        }

        public static void crearAfiliado(string username, string tipoDocumento, string numDocumento, string contraseña, string nombre, string apellido, DateTime fechaNacimiento, string sexo, string direccion, string email, string telefono, string estadoCivil, string planMedico, string encargado) {

            int doc = Convert.ToInt32(numDocumento);
            int tel = Convert.ToInt32(telefono);
            int plan = Convert.ToInt32(planMedico);
            string genero = cifrarGenero(sexo);

            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Usuarios (username, doc_tipo, doc_nro, contrasenia, nombre, apellido, fec_nac, sexo, domicilio, mail, telefono) VALUES ('{0}', '{1}' , '{2}', '{3}', '{4}', '{5}', '{6}' , '{7}', '{8}', '{9}', '{10}')",
                 username, tipoDocumento, doc, contraseña, nombre, apellido, fechaNacimiento, genero, direccion, email, tel));

            SqlCommand otroComando = new SqlCommand(string.Format("INSERT INTO Afiliado (username, plan_id, afiliado_estado_civil, afiliado_fec_baja, afiliado_encargado) VALUES ('{0}', '{1}' , '{2}', '{3}', '{4}')",
                username, plan, estadoCivil, "01/01/2018", encargado));
        }
    }
}
