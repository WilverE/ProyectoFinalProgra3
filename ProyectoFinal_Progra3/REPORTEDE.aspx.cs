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
    public partial class ReporteEnfermedades : System.Web.UI.Page
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
            List<HistorialMedico> AlbumnAux = new List<HistorialMedico>();
            foreach (var alb in historial)
            {
                HistorialMedico alumnosx = historial.Find(c => c.Diagnostico != " ");
                if (alb.Diagnostico != null)
                {
                    AlbumnAux.Add(alb);
                }
            }
            GridView1.DataSource = AlbumnAux;
            GridView1.DataBind();
        }
    }
}