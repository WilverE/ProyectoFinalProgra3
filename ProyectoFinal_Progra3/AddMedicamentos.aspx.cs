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
    public partial class AddMedicamentos : System.Web.UI.Page
    {
        static List<Medicamentos> Medicamentos = new List<Medicamentos>();
        static List<string> Enfermedad = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerJson();
            }
        }
      
        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(Medicamentos);
            string archivo = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Medicamentos = JsonConvert.DeserializeObject<List<Medicamentos>>(json);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Enfermedad.Add(TextBox12.Text);
            TextBox12.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Medicamentos uni = new Medicamentos();
            uni.CMedicamento = TextBox5.Text;
            uni.Ingrediente = TextBox6.Text;
            uni.Laboratorio = TextBox11.Text;
            uni.Enfermedades = Enfermedad.ToArray().ToList();
            Medicamentos.Add(uni);
            GuardarJson();
            Enfermedad.Clear();

            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox12.Text = "";
            TextBox11.Text = "";
        }
    }
}