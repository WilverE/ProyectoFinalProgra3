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
    public partial class ReporteListadoMedicamentos : System.Web.UI.Page
    {
        static List<HistorialMedico> historial = new List<HistorialMedico>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerJson();
                visualizar();
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
        private void visualizar()
        {

            List<string> AlbumnAux = new List<string>();
            foreach (var alb in historial)
            {
                HistorialMedico alumnosx = historial.Find(c => c.Receta != null);
                if (alb.Receta != null)
                {
                    GridView1.DataSource = alumnosx.Receta;
                    GridView1.DataBind();
                }
            }
        }
    }
}