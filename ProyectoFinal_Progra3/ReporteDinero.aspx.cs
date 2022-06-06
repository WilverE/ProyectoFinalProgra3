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
    public partial class ReporteDinero : System.Web.UI.Page
    {
        static List<HistorialMedico> historial = new List<HistorialMedico>();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("HistorialMedico.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            historial = JsonConvert.DeserializeObject<List<HistorialMedico>>(json);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int acum = 0;
            List<HistorialMedico> AlbumnAux = new List<HistorialMedico>();
            foreach (var alb in historial)
            {

                if (((DateTime.Compare(alb.Fecha, Calendar1.SelectedDate) > 0) && (DateTime.Compare(alb.Fecha, Calendar2.SelectedDate) < 0)) || (DateTime.Compare(alb.Fecha, Calendar1.SelectedDate) == 0) || (DateTime.Compare(alb.Fecha, Calendar2.SelectedDate) == 0))
                {
                    AlbumnAux.Add(alb);
                    acum += alb.Costo;
                }
            }
            GridView1.DataSource = AlbumnAux;
            GridView1.DataBind();
            TextBox1.Text = acum.ToString();
        }
    }
}