
using RestSharp;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Model;
using Controler;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

public partial class CargaMasiva : System.Web.UI.Page
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


        try
        { //try TLS 1.3
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)12288
                                                 | (SecurityProtocolType)3072
                                                 | (SecurityProtocolType)768
                                                 | SecurityProtocolType.Tls;
        }
        catch (NotSupportedException)
        {
            try
            { //try TLS 1.2
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072
                                                     | (SecurityProtocolType)768
                                                     | SecurityProtocolType.Tls;
            }
            catch (NotSupportedException)
            {
                try
                { //try TLS 1.1
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)768
                                                         | SecurityProtocolType.Tls;
                }
                catch (NotSupportedException)
                { //TLS 1.0
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                }
            }
        }
    }

    
     protected void Button1_Click(object sender, EventArgs e)
        {
            string ruta_carpeta = HttpContext.Current.Server.MapPath("~/Temporal");

            if (!Directory.Exists(ruta_carpeta))
            {
                Directory.CreateDirectory(ruta_carpeta);
            }

            //GUARDAMOS EL ARCHIVO EN LOCAL
            var ruta_guardado = Path.Combine(ruta_carpeta, FileUpload1.FileName);
            FileUpload1.SaveAs(ruta_guardado);


            IWorkbook MiExcel = null;
            FileStream fs = new FileStream(ruta_guardado, FileMode.Open, FileAccess.Read);

            if (Path.GetExtension(ruta_guardado) == ".xlsx")
                MiExcel = new XSSFWorkbook(fs);
            else
                MiExcel = new HSSFWorkbook(fs);


            ISheet hoja = MiExcel.GetSheetAt(0);

            DataTable table = new DataTable();
            
            table.Columns.Add("Ai_orden", typeof(int));
            table.Columns.Add("Av_cmd_code", typeof(string));
            table.Columns.Add("Av_cmd_description", typeof(string));
            table.Columns.Add("Af_weight", typeof(float));
            table.Columns.Add("Av_weightunit", typeof(string));
            table.Columns.Add("Af_count", typeof(float));
            table.Columns.Add("Av_countunit", typeof(string));

            if (hoja != null) {

                int cantidadfilas = hoja.LastRowNum;

                for (int i = 1; i <= cantidadfilas; i++) {
                    IRow fila = hoja.GetRow(i);


                    if(fila != null)
                        table.Rows.Add(
                            fila.GetCell(0, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(0, MissingCellPolicy.RETURN_NULL_AND_BLANK).NumericCellValue.ToString() : "",
                            fila.GetCell(1, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(1, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString() : "",
                            fila.GetCell(2, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(1, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString()+"-"+fila.GetCell(2, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString() : "",
                            fila.GetCell(3, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null  ? fila.GetCell(3, MissingCellPolicy.RETURN_NULL_AND_BLANK).NumericCellValue.ToString() : "",
                             fila.GetCell(4, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(4, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString() : "",
                             fila.GetCell(5, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(5, MissingCellPolicy.RETURN_NULL_AND_BLANK).NumericCellValue.ToString() : "",
                             fila.GetCell(6, MissingCellPolicy.RETURN_NULL_AND_BLANK) != null ? fila.GetCell(6, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString() : ""
                            );
                }
            }

            GridView1.DataSource = table;
            GridView1.DataBind();
            //string nombre = txtName.Text;
            //txtName.Text = "";
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "hola" + nombre + "');", true);
            int resultado = cargarEnSQL(table);

            if (resultado == 1) {
                GridView1.DataSource = table;
                GridView1.DataBind();
            }

        }




        public int cargarEnSQL(DataTable tabla)
        {
            int resultado = 0;
            try
            {
                //NOS CONECTAMOS CON LA BASE DE DATOS
                string cadena = @"Data source=DESKTOP-CV57FOU\SQLEXPRESS; Initial Catalog=DBCARGA; User ID=jdev; Password=tdr123;Trusted_Connection=false;MultipleActiveResultSets=true";
                using (SqlConnection cn = new SqlConnection(cadena))
                {
                    SqlCommand cmd = new SqlCommand("usp_cargarMasivaMercancia4", cn);
                    //cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.Add("EstructuraCargaMasivaMercancia", SqlDbType.Structured).Value = tabla;
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                }
            }
            catch (Exception ex)
            {

                string mensaje = ex.Message.ToString();
                resultado = 0;
            }

            return resultado;
        }


    


}