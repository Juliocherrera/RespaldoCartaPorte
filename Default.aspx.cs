using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static storedProcedure sql = new storedProcedure("miConexion");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    [WebMethod]
    public static List<string> verinfocompany(string id)
    {
        List<string> list = new List<string>();
        list = sql.recuperaRegistros("select cmp_id, cmp_address1, cmp_address2, cmp_address3,cmp_zip, cty_nmstct,cmp_latseconds/3600 as lat , (cmp_longseconds *-1)/3600  as long from company where cmp_id= '"+id+"'");
        return list;
    }

    [WebMethod]
    public static string updtlatlng(string lat ,string lng ,string id)
    {
        string result = "OK";
        //if (sql.ejecutaSQL("update company set cmp_latseconds='"+ lat + "', cmp_longseconds='"+lng+"' where cmp_id= '"+id+"'")) 
        //{
        //    result = "o";
        //}
        return result;
    }
    [WebMethod]
    public static string[] metlatlng(string latlng)
    {
        latlng = latlng.Replace("(","").Replace(" ","").Replace(")","");
        string[] separadas;
        separadas = latlng.Split(',');
        return separadas;
    }
}