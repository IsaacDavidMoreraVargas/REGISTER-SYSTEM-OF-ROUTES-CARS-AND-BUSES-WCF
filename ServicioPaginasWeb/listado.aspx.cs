using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class listado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
         try
            {
                String ProvinciaBuscar = "SELECT * FROM dbo.ruta where Provincia='" + DropProvinicia.Text + "'";
                ServiceConexionR.ServiciosRutasClient WS = new ServiceConexionR.ServiciosRutasClient();
                DataSet data = WS.GetRutaEspecifico(ProvinciaBuscar);
                TextMostrar.DataSource = data.Tables[0];
                TextMostrar.DataBind();
                mensaje.Text = "Rutas encontradas en provincia: " + DropProvinicia.Text;

            }catch(Exception)
            {
                mensaje.Text = "Existe algun Error";

            }
    }
}