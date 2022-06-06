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
    public partial class ReportPacientesNoPresentes : System.Web.UI.Page
    {
        static List<Agenda> CitasTemp = new List<Agenda>();
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
            CitasTemp = JsonConvert.DeserializeObject<List<Agenda>>(json);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int acum = 0;
            List<Agenda> SITUACION = new List<Agenda>();
            foreach (var alb in CitasTemp)
            {

                if (alb.Situacion == "No asistio o no ha asistido") 
                {
                    SITUACION.Add(alb);
                    acum += 1;
                }
            }
            GridView1.DataSource = SITUACION;
            GridView1.DataBind();
            TextBox1.Text = "El total de pacientes que no asistieron o no han asisitido: " + acum;
        }
    }
}