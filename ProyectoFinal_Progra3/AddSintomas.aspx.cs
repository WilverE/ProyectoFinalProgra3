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
    public partial class AddSintomas : System.Web.UI.Page
    {
        public static List<Sintomas> SintomasTemp = new List<Sintomas>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        public void LeerJson()
        {

            //string archivo = Server.MapPath("Sintomas.json");
            //StreamReader jsonStream = File.OpenText(archivo);
            //string json = jsonStream.ReadToEnd();
            //jsonStream.Close();
            //SintomasTemp = JsonConvert.DeserializeObject<List<Sintomas>>(json);
        }

        public void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(SintomasTemp);
            string archivo = Server.MapPath("Sintomas.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Sintomas sintoma = new Sintomas();
            sintoma.CSintoma = TextBox5.Text;
            sintoma.Sintoma = TextBox6.Text;
            SintomasTemp.Add(sintoma);
            GuardarJson();
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}