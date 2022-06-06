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
    public partial class UpdatePacientes : System.Web.UI.Page
    {
        static List<Pacientes> pacientes = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
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

        }
        private void GuardarJson()
        {

            string json2 = JsonConvert.SerializeObject(pacientes);
            string archivo2 = Server.MapPath("Pacientess.json");
            System.IO.File.WriteAllText(archivo2, json2);
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
                    Calendar1.SelectedDate = alumnosx.FechaNacimiento ;
                    int telefono = alumnosx.Telefono;
                    TextBox15.Text = telefono.ToString();
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
                Response.Write("<script>alert('Paciente no encontrado')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in pacientes)
            {

                Pacientes alumnosx = pacientes.Find(c => c.NIT_Paciente == TextBox1.Text);
                if (alumnosx != null)
                {
                    
                    alumnosx.NIT_Paciente = TextBox5.Text;
                    alumnosx.NombrePaciente = TextBox6.Text;
                    alumnosx.ApellidoPaciente = TextBox11.Text;
                     alumnosx.Direccion = TextBox12.Text ;
                    alumnosx.FechaNacimiento = Calendar1.SelectedDate;
                   alumnosx.Telefono = int.Parse(TextBox15.Text);
                   
                }
            }
            GuardarJson();
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox15.Text = "";
            MessageBox.Show("Paciente Modificado");
        }
    }
}