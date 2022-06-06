using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoFinal_Progra3
{
    public partial class DeleteCitas : System.Web.UI.Page
    {
        static List<Agenda> citas = new List<Agenda>();
        static List<Pacientes> PacientesTemp = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Agenda.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            citas = JsonConvert.DeserializeObject<List<Agenda>>(json);


            string archivo2 = Server.MapPath("Pacientess.json");
            StreamReader jsonStream2 = File.OpenText(archivo2);
            string json2 = jsonStream2.ReadToEnd();
            jsonStream2.Close();
            PacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json2);
        }
        private void GuardarJson()
        {

            string json2 = JsonConvert.SerializeObject(citas);
            string archivo2 = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo2, json2);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in citas)
            {
                Agenda alumnosx = citas.Find(c => c.NumReferencia == TextBox1.Text);
                if (alumnosx != null)
                {
                    Pacientes alumnos = PacientesTemp.Find(c => c.NIT_Paciente == alumnosx.NIT_P);
                    TextBox2.Text = alumnosx.NIT_P + " - " + alumnos.NombrePaciente + " , " + alumnos.ApellidoPaciente;
                    DateTime Fechacit = alumnosx.Fecha;
                    TextBox3.Text = Fechacit.ToString();
                    TextBox4.Text = alumnosx.HoraI + " a " + alumnosx.HoraF;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                Response.Write("<script>alert('Cita no encontrada')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
                int index  = citas.FindIndex(c => c.NumReferencia == TextBox1.Text);
                if (index != -1)
                {
                    citas.RemoveAt(index);
                }
            
            GuardarJson();
        }
    }
}