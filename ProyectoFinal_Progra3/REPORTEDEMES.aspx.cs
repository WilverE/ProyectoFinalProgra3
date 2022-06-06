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
    public partial class ReportMes : System.Web.UI.Page
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
            List<Agenda> AlbumnAux = new List<Agenda>();
            foreach (var alb in CitasTemp)
            {

                if (((DateTime.Compare(alb.Fecha, Calendar1.SelectedDate) > 0) && (DateTime.Compare(alb.Fecha, Calendar2.SelectedDate) < 0)) || (DateTime.Compare(alb.Fecha, Calendar1.SelectedDate) == 0) || (DateTime.Compare(alb.Fecha, Calendar2.SelectedDate) == 0))
                {
                    AlbumnAux.Add(alb);
                    acum += 1;
                }
            }
            GridView1.DataSource = AlbumnAux;
            GridView1.DataBind();
            TextBox1.Text = "El total de pacientes entre estas dos fechas es: " + acum;
        }
    }
}