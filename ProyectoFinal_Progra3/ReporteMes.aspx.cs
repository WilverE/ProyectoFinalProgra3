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
    public partial class ReporteMes : System.Web.UI.Page
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
            string mes = DropDownList1.SelectedValue;
            int DiaAux = 0;
            int aux = 0;
            List<Agenda> AlbumnAux = new List<Agenda>();
            int mes1 = 0;
            if (mes == "Enero") { mes1 = 1; }
            if (mes == "Febrero") { mes1 = 2; } 
            if (mes == "Marzo") { mes1 = 3; }
            if (mes == "Abril") { mes1 = 4; }
            if (mes == "Mayo") { mes1 = 5; }
            if (mes == "Junio") { mes1 = 6; }
            if (mes == "Julio") { mes1 = 7; }
            if (mes == "Agosto") { mes1 = 8; }
            if (mes == "Septiembre") { mes1 = 9; }
            if (mes == "Octubre") { mes1 = 10; }
            if (mes == "Noviembre") { mes1 = 11; }
            if (mes == "Diciembre") { mes1 = 12; }
            for (int x = 1; x <= 31; x++)
            {
                Agenda index = CitasTemp.Find(c => c.Fecha.Month == mes1);
         
                if (index.Fecha.Month == mes1 && index.Fecha.Day == x)
                    {
                       DiaAux += 1;
                    }
                if (DiaAux > aux)
                {
                    AlbumnAux.Add(index); aux = DiaAux; }
            }
            GridView1.DataSource = AlbumnAux;
            GridView1.DataBind();
        }
    }
}