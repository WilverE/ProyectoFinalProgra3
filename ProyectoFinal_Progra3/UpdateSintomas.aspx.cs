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
    public partial class UpdateSintomas : System.Web.UI.Page
    {
        static List<Sintomas> sintomas = new List<Sintomas>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Sintomas.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            sintomas = JsonConvert.DeserializeObject<List<Sintomas>>(json);

        }
        private void GuardarJson()
        {

            string json2 = JsonConvert.SerializeObject(sintomas);
            string archivo2 = Server.MapPath("Sintomas.json");
            System.IO.File.WriteAllText(archivo2, json2);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (var universidad in sintomas)
            {
                Sintomas alumnosx = sintomas.Find(c => c.CSintoma == TextBox1.Text);
                if (alumnosx != null)
                {

                    TextBox5.Text = alumnosx.CSintoma;
                    TextBox6.Text = alumnosx.Sintoma;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                TextBox1.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                Response.Write("<script>alert('Sintoma no encontrado')</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (var universidad in sintomas)
            {

                Sintomas alumnosx = sintomas.Find(c => c.CSintoma == TextBox1.Text);
                if (alumnosx != null)
                {

                    alumnosx.CSintoma = TextBox5.Text;
                    alumnosx.Sintoma  = TextBox6.Text;

                }
            }
            GuardarJson();
            TextBox1.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            MessageBox.Show("Sintoma Modificado");
        }
    }
}