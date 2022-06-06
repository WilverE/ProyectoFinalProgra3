using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal_Progra3
{
    public class Pacientes
    {
        public string NIT_Paciente { get; set; }
        public string NombrePaciente { get; set; }

        public string ApellidoPaciente { get; set; }

        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int  Telefono{ get; set; }
    }
}