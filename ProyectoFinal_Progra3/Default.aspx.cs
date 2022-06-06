using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Progra3
{
    public partial class _Default : Page
    {

        public static List<Pacientes> PacientesTemp = new List<Pacientes>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
           // {
             //   LeerJson();
           // }
            ////obtener la identidad del usuario acutalmente logueado
            //var identidad = (FormsIdentity)Context.User.Identity;

            ////Verificar el nivel que se le asigno cuando se creo el ticket de autenticacion al momento 
            ////de hacer el login. Esos datos son string entonces el 1 va entre comillas "1"
            //if (identidad.Ticket.UserData != "Secretaria")
            //{
            //    //Si el usuario no tiene permitido entrar a esta página, lo redirigimos a una página en la que si tenga permiso
            //    Response.Redirect("WebForm1.aspx", true);
            //}
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void LeerJson()
        {

            string archivo = Server.MapPath("Pacientess.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            PacientesTemp = JsonConvert.DeserializeObject<List<Pacientes>>(json);
        }

        public void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(PacientesTemp);
            string archivo = Server.MapPath("Pacientess.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Pacientes paciente = new Pacientes();
            paciente.NIT_Paciente = TextBox5.Text;
            paciente.NombrePaciente = TextBox6.Text;
            paciente.ApellidoPaciente = TextBox11.Text;
            paciente.Direccion = TextBox12.Text;
            paciente.FechaNacimiento = Calendar1.SelectedDate;
            paciente.Telefono = int.Parse(TextBox15.Text);
            PacientesTemp.Add(paciente);
            GuardarJson();
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox15.Text = "";
        }
    }
}