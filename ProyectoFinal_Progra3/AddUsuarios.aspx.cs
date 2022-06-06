using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal_Progra3
{
    public partial class AddUsuarios : System.Web.UI.Page
    {

        public static List<Usuarios> usuarios = new List<Usuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LeerJson();
            }
            
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void LeerJson()
        {

            //string archivo = Server.MapPath("Usuarios.json");
            //StreamReader jsonStream = File.OpenText(archivo);
            //string json = jsonStream.ReadToEnd();
            //jsonStream.Close();
            //usuarios = JsonConvert.DeserializeObject<List<Usuarios>>(json);
        }

        public void GuardarJson()
        {

            string json = JsonConvert.SerializeObject(usuarios);
            string archivo = Server.MapPath("Usuarios.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = TextBox5.Text;
            usuario.Contraseña = TextBox6.Text;
            usuario.ROL = DropDownList1.SelectedValue;
            
            usuarios.Add(usuario);
            GuardarJson();
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}