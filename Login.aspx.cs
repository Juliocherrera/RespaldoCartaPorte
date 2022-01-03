using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    static storedProcedure sql = new storedProcedure("miConexion");
    static Encryptor Encryptor = new Encryptor();
    static List<string> usu = new List<string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Redirect("CartaPorte.aspx");
        Session["idusu"] = null;
        Session["usuario"] = null;
        Session["correo"] = null;
    }

    [WebMethod]
    public static List<string> valida(string user, string pass)
    {
        usu.Clear();
        string password = "";
        List<string> resultusu = new List<string>();
        resultusu=sql.recuperaRegistros("exec spvaluser '" + user + "'");
        if (resultusu.Count == 0)
        {
            usu.Add("Error");
        }
        else 
        {
            password = Encryptor.DecodeFrom64(resultusu[3].ToString());
            if (password.Equals(pass))
            {
                HttpContext.Current.Session["idusu"] = resultusu[0].ToString();
                HttpContext.Current.Session["usuario"] = resultusu[1].ToString();
                HttpContext.Current.Session["correo"] = resultusu[2].ToString();

                usu.Add(resultusu[0].ToString());
                usu.Add(resultusu[1].ToString());
                usu.Add(resultusu[2].ToString());
            }
            else
            {
                usu.Add("Error");
            }
        }
       
        return usu;
    }

    [WebMethod]
    public static string updatepass(string user, string pass1, string pass2)
    {
        string result = ""; 
        if (pass1.Equals(pass2))
        {
            string nuepass = "";
            nuepass=Encryptor.EncodeTo64(pass1);
            if (sql.ejecutaSQL("update tlbUserAccess set usr_password='" + nuepass + "' WHERE usr_mail='" + user + "' and  usr_access = 'Y'"))
            {
                result = "ok";
            }
            else { result = "error"; }            
        }
        else { result = "error"; }
        return result;
    }

}