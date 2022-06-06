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
    public partial class Login : System.Web.UI.Page
    {
        static List<Usuarios> usuario = new List<Usuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LeerJson();
            }
        }
        private void LeerJson()
        {

            string archivo = Server.MapPath("Usuarios.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            usuario = JsonConvert.DeserializeObject<List<Usuarios>>(json);

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool encontrado = true;
            foreach (var universidad in usuario)
            {
                Usuarios alumnosx = usuario.Find(c => c.Usuario == Login1.UserName);
                if (alumnosx != null)
                {
                    string usuario = Login1.UserName;
                    string password = Login1.Password;
                    if ((usuario == alumnosx.Usuario) && (password == alumnosx.Contraseña))
                    {
                        FormsAuthenticationTicket tkt;
                        string cookiestr;
                        HttpCookie ck;
                        tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                        DateTime.Now.AddMinutes(30), Login1.RememberMeSet, alumnosx.ROL);
                        cookiestr = FormsAuthentication.Encrypt(tkt);
                        ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                        if (Login1.RememberMeSet)
                            ck.Expires = tkt.Expiration;
                        ck.Path = FormsAuthentication.FormsCookiePath;
                        Response.Cookies.Add(ck);

                        string strRedirect;
                        strRedirect = Request["ReturnUrl"];
                        if (strRedirect == null)
                            strRedirect = "PaginaINICIO.aspx";
                        Response.Redirect(strRedirect, true);
                    }
                    encontrado = true;
                }
            }

        }
    }
}