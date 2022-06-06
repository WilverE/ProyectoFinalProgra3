using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Progra3
{
    public partial class AddConsulta : System.Web.UI.Page
    {
        static List<Sintomas> sintomas = new List<Sintomas>();
        static List<Pacientes> pacientes = new List<Pacientes>();
        static List<Medicamentos> medicamento = new List<Medicamentos>();
        static List<HistorialMedico> historial = new List<HistorialMedico>();
        static List<Agenda> Citas = new List<Agenda>();
        static List<string> receta = new List<string>();
        static List<string> sinto = new List<string>();
        int aux;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LeerJson();
                CargarSintomas();
                CargarMedicamento(); 
            }
            idconsulta();

        }
        private void idconsulta ()
        {
            
            bool encontrado = false;
            foreach (var citas in historial)
            {
                HistorialMedico CITA = historial.Find(c => c.IdConsulta > aux);
                if (CITA != null)
                {
                    int x = CITA.IdConsulta;
                    aux = x + 1;
                    encontrado = true;
                }
                if (!encontrado)
                {
                    aux = 0;
                }
            }


        }
        private void LeerJson()
        {
            string archiv = Server.MapPath("HistorialMedico.json");
            StreamReader jsonStrea = File.OpenText(archiv);
            string jso = jsonStrea.ReadToEnd();
            jsonStrea.Close();
            historial = JsonConvert.DeserializeObject<List<HistorialMedico>>(jso);

            string archivo = Server.MapPath("Pacientess.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            pacientes = JsonConvert.DeserializeObject<List<Pacientes>>(json);


            string archivo2 = Server.MapPath("Agenda.json");
            StreamReader jsonStream2 = File.OpenText(archivo2);
            string json2 = jsonStream2.ReadToEnd();
            jsonStream2.Close();
            Citas = JsonConvert.DeserializeObject<List<Agenda>>(json2);


            string archivo3 = Server.MapPath("Sintomas.json");
            StreamReader jsonStream3 = File.OpenText(archivo3);
            string json3 = jsonStream3.ReadToEnd();
            jsonStream3.Close();
            sintomas = JsonConvert.DeserializeObject<List<Sintomas>>(json3);

            string archivo4 = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream4 = File.OpenText(archivo4);
            string json4 = jsonStream4.ReadToEnd();
            jsonStream4.Close();
            medicamento = JsonConvert.DeserializeObject<List<Medicamentos>>(json4);

        }
        private void GuardarJson()
        {
            string json2 = JsonConvert.SerializeObject(Citas);
            string archivo3 = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo3, json2);

            string json1 = JsonConvert.SerializeObject(historial);
            string archivo1 = Server.MapPath("HistorialMedico.json");
            System.IO.File.WriteAllText(archivo1, json1);

        }
        private void CargarSintomas()
        {
            foreach (var pa in sintomas)
            {
                DropDownList2.Items.Add(pa.Sintoma);
            }
        }
        private void CargarMedicamento()
        {
            foreach (var pa in medicamento)
            {
                DropDownList3.Items.Add(pa.Ingrediente+ " - "+ pa.Laboratorio);
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            bool encontrado2 = false;
            string nitt = " ";
            foreach (var citas in Citas)
            {
                Agenda CITA = Citas.Find(c => c.NumReferencia == TextBox1.Text);
                if (CITA != null)
                {
                    nitt = CITA.NIT_P;
                    encontrado = true;
                } }
                if (!encontrado)
                {
                    TextBox1.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox11.Text = "";
                    TextBox16.Text = "";
                    Response.Write("<script>alert('Cita no encontrado')</script>");
                }

            foreach (var paci in pacientes)
            {
                Pacientes PACI = pacientes.Find(c => c.NIT_Paciente == nitt);
                if (PACI != null)
                {

                    TextBox5.Text = PACI.NIT_Paciente;
                    TextBox6.Text = PACI.NombrePaciente;
                    TextBox11.Text = PACI.ApellidoPaciente;
                    DateTime nacii = PACI.FechaNacimiento;
                    TextBox16.Text = nacii.ToString();
                    encontrado2 = true;
                }
            }
                if (!encontrado2)
                {
                    TextBox1.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox11.Text = "";
                    TextBox16.Text = "";
                    Response.Write("<script>alert('Cita no encontrado')</script>");
                }
            
            }
        protected void Button2_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var paci in Citas)
            {
                Agenda PACI = Citas.Find(c => c.NumReferencia == TextBox1.Text);
                if (PACI != null)
                {
                    PACI.Situacion = "ASISTIO";
                    encontrado = true;
                }
                if (!encontrado)
                {
                    PACI.Situacion = "No asistio o no ha asistido";
                }
            }

         
   
            HistorialMedico uni = new HistorialMedico();
            uni.IdConsulta = aux;
            uni.NitPac = TextBox5.Text;
            uni.Fecha = DateTime.Parse(TextBox20.Text);
            uni.HoraConsulta = TextBox18.Text;
            uni.Tempertatura = TextBox21.Text;
            uni.Presion = TextBox22.Text;
            uni.Diagnostico = TextBox24.Text;
            uni.Tratamiento = TextBox23.Text;
            uni.Sintomas = sinto.ToArray().ToList();
            uni.Receta = receta.ToArray().ToList();
            uni.Costo = int.Parse(DropDownList4.SelectedValue);
            historial.Add(uni);
            GuardarJson();
            
            sinto.Clear();
            receta.Clear();
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox16.Text = "";
            TextBox11.Text = "";

            TextBox20.Text = "";
            TextBox18.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox24.Text = "";
            TextBox23.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            sinto.Add(DropDownList2.SelectedValue);
            DropDownList2.SelectedIndex = -1;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            receta.Add(DropDownList3.SelectedValue);
            DropDownList3.SelectedIndex = -1;
        }
    }
}