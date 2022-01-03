using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

public partial class DatosCompany : System.Web.UI.Page
{
    static storedProcedure sql = new storedProcedure("miConexion");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static string datacompany()
    {
        DataTable dt = new DataTable();
        string result = "";
        try
        {
            //dt = sql.ObtieneTabla("select top 100 cmp_id, cmp_address1, cmp_address2, cmp_address3,cmp_zip, cty_nmstct,cmp_latseconds/3600 as lat , (cmp_longseconds *-1)/3600  as long from company order by cmp_createdate desc");
            dt = sql.ObtieneTabla("select top 280 concat('<tr><td>',cmp_id,'</td><td>',cmp_address1,'</td><td>',cmp_address2,'</td><td>',cmp_address3,'</td><td>',cmp_zip,'</td><td>',cty_nmstct,'</td><td>',cmp_latseconds/3600,'</td><td>',(cmp_longseconds *-1)/3600,'</td></tr>') AS data from company order by cmp_createdate desc");
            for (int i = 0; i < dt.Rows.Count - 1; i++)
            {
                result += dt.Rows[i][0].ToString();
            }
            //result = DataTableToJSONWithStringBuilder(dt);
        }
        catch { }
        return result;
    }

    [WebMethod]
    public static object gettable()
    {
        List<Company> lista = new List<Company>();
        //lista = sql.recuperaRegistros("select TOP 5 cmp_id, cmp_address1, cmp_address2, cmp_address3,cmp_zip, cty_nmstct,cmp_latseconds/3600 as lat , (cmp_longseconds *-1)/3600  as long from company order by cmp_createdate desc");
        DataTable data = new DataTable();
        data = sql.ObtieneTabla("select TOP 600 cmp_id, cmp_address1, cmp_address2, cmp_address3,cmp_zip, cty_nmstct,cmp_latseconds/3600 as lat , (cmp_longseconds *-1)/3600  as long from company order by cmp_createdate desc");
        if (data.Rows.Count>0) 
        {
            for (int i = 0; i < data.Rows.Count-1; i++)
            {
                lista.Add(new Company(data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), data.Rows[i][3].ToString(), data.Rows[i][4].ToString(), data.Rows[i][5].ToString(), data.Rows[i][6].ToString(), data.Rows[i][7].ToString()));
            }
        }       
        object json = new { data = lista };
        return json;
    }

    public static string DataTableToJSONWithStringBuilder(DataTable table)
    {
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
        Dictionary<string, object> childRow;
        foreach (DataRow row in table.Rows)
        {
            childRow = new Dictionary<string, object>();
            foreach (DataColumn col in table.Columns)
            {
                childRow.Add(col.ColumnName, row[col]);
            }
            parentRow.Add(childRow);
        }
        return jsSerializer.Serialize(parentRow);
    }

}