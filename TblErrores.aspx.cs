using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TblErrores : System.Web.UI.Page
{
    static storedProcedure sql = new storedProcedure("miConexion");
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string id = Session["idusu"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Login.aspx");
        }
      
    }

    [WebMethod]
    public static object gettable()
    {
        List<ErroresCP> lista = new List<ErroresCP>();

        DataTable data = new DataTable();
        data = sql.ObtieneTabla("SELECT TOP 50 * FROM VISTA_Carta_Porte_Errores ORDER BY Fecha desc");
        if (data.Rows.Count > 0)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                lista.Add(new ErroresCP(data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), data.Rows[i][3].ToString(), data.Rows[i][4].ToString(), data.Rows[i][5].ToString(), data.Rows[i][6].ToString(), data.Rows[i][7].ToString(), data.Rows[i][8].ToString()));
            }
        }
        object json = new { data = lista };
        return json;
    }
}