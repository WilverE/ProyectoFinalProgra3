using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal_Progra3
{
    public class Medicamentos
    {
        public string CMedicamento { get; set; }
        public string Ingrediente { get; set; }
        public string Laboratorio { get; set; }
        public List<string> Enfermedades { get; set; }
    }
}