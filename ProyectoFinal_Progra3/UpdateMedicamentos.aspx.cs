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
    public partial class UpdateMedicamentos : System.Web.UI.Page
    {
        static List<Medicamentos> medicamentos = new List<Medicamentos>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Medicamentos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            medicamentos = JsonConvert.DeserializeObject<List<Medicamentos>>(json);

        }
        private void GuardarJson()
        {

            string json2 = JsonConvert.SerializeObject(medicamentos);
            string archivo2 = Server.MapPath("Medicamentos.json");
            System.IO.File.WriteAllText(archivo2, json2);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in medicamentos)
            {
                Medicamentos alumnosx = medicamentos.Find(c => c.CMedicamento == TextBox1.Text);
                if (alumnosx != null)
                {

                    TextBox5.Text = alumnosx.CMedicamento;
                    TextBox6.Text = alumnosx.Ingrediente;
                    TextBox11.Text = alumnosx.Laboratorio;
                   
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                TextBox1.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox11.Text = "";
                Response.Write("<script>alert('Medicamento no encontrado')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in medicamentos)
            {

                Medicamentos alumnosx = medicamentos.Find(c => c.CMedicamento == TextBox1.Text);
                if (alumnosx != null)
                {

                    alumnosx.CMedicamento = TextBox5.Text;
                    alumnosx.Ingrediente = TextBox6.Text;
                    alumnosx.Laboratorio = TextBox11.Text;

                }
            }
            GuardarJson();
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox11.Text = "";
            MessageBox.Show("Medicamento Modificado");
        }
    }
}