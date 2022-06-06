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
    public partial class AddCita : System.Web.UI.Page
    {
        static List<Pacientes> pacientes = new List<Pacientes>();
        static List<Agenda> Citas = new List<Agenda>();
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerde agendar citas de una hora completa por ejemplo 7:00 - 8:00");
            if (!IsPostBack)
            {
                LeerJson();
            }
        }
 
        private void LeerJson()
        {

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

        }
        private void GuardarJson()
        {


            string json1 = JsonConvert.SerializeObject(Citas);
            string archivo1 = Server.MapPath("Agenda.json");
            System.IO.File.WriteAllText(archivo1, json1);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in pacientes)
            {
                Pacientes alumnosx = pacientes.Find(c => c.NIT_Paciente == TextBox1.Text);
                if (alumnosx != null)
                {

                    TextBox5.Text = alumnosx.NIT_Paciente;
                    TextBox6.Text = alumnosx.NombrePaciente;
                    TextBox11.Text = alumnosx.ApellidoPaciente;
                    TextBox12.Text = alumnosx.Direccion;
                    int cel = alumnosx.Telefono;
                    TextBox15.Text = cel.ToString();
                    DateTime Nacimiento = alumnosx.FechaNacimiento;
                    TextBox16.Text = Nacimiento.ToString();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                TextBox1.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                TextBox15.Text = "";
                TextBox16.Text = "";
                Response.Write("<script>alert('Paciente no encontrado')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in Citas)
            {
                Agenda  alumnosx = Citas.Find(c => c.Fecha == Calendar1.SelectedDate);
                if (alumnosx != null && alumnosx.HoraF == TextBox19.Text && alumnosx.HoraI == TextBox18.Text)
                {

                    MessageBox.Show("Para esa fecha y hora ya hay una cita agendada");
                    GuardarJson();
                    TextBox1.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox12.Text = "";
                    TextBox11.Text = "";
                    TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox18.Text = "";
                    TextBox19.Text = "";
                    TextBox20.Text = "";
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Agenda uni = new Agenda();
                uni.NumReferencia = TextBox20.Text;
                uni.NIT_P = TextBox5.Text;
                uni.Fecha = Calendar1.SelectedDate;
                uni.HoraI = TextBox18.Text;
                uni.HoraF = TextBox19.Text;
                uni.Situacion = "No asistio o no ha asistido";
                MessageBox.Show("Cita agendada para:" + uni.Fecha + " De " + uni.HoraI + " a " +uni.HoraF);
                Citas.Add(uni);
                GuardarJson();
                TextBox1.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox12.Text = "";
                TextBox11.Text = "";
                TextBox15.Text = "";
                TextBox16.Text = "";
                TextBox18.Text = "";
                TextBox19.Text = "";
                TextBox20.Text = "";

            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}