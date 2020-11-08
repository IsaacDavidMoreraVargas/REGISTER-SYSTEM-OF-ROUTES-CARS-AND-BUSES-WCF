using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ruta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ServiceConexionR.ServiciosRutasClient WD = new ServiceConexionR.ServiciosRutasClient();
        DataSet data = WD.GetAllRuta();
        int mayor = TextMostrar.Rows.Count;

        if (mayor >= 0)
        {
            TextMostrar.DataSource = data.Tables[0];
            TextMostrar.DataBind();
            ResultadoOperacion.Text = "Mostrando todos \n los buses";

        }
        else
        {
            ResultadoOperacion.Text = "Base de datos \n vacia";
        }
    }

    string provincia = "";
    string inicioR = "";
    string finR = "";
    string rural = "";
    int kilometros = 0;

    public void vaciarDatos()
    {

        DropProvincia.Text = "---";
        TextInicio.Text = "";
        TextFin.Text = "";
        DropRural.Text = "---";
        TextKilometros.Text = "";
        TextClave.Text = "Digite clave ruta...";
    }

    bool completado = true;
    string negativo = "";
    public void validar()
    {

        if (DropProvincia.Text == "---")
        {
            completado = false;
            negativo += "\n-Provincia vacio";

        }
        else
        {
            provincia = DropProvincia.Text;

        }

        if (TextInicio.Text == " ")
        {
            completado = false;
            negativo += "\n-Punto inicio vacio";
        }
        else
        {
            inicioR = TextInicio.Text;

        }

        if (TextInicio.Text.Length <= 0)
        {
            completado = false;
            negativo += "\n-Punto inicio vacio";
        }
        else
        {
            inicioR = TextInicio.Text;

        }

        if (TextFin.Text == " ")
        {
            completado = false;
            negativo += "\n-Punto fin vacio";
        }
        else
        {
            finR = TextFin.Text;

        }

        if (TextFin.Text.Length <= 0)
        {
            completado = false;
            negativo += "\n-Punto fin vacio";
        }
        else
        {
            finR = TextFin.Text;

        }

        if (DropRural.Text == "---")
        {
            completado = false;
            negativo += "\n-Rural vacio";
        }
        else
        {
            rural = DropRural.Text;

        }

        try
        {
            kilometros = Convert.ToInt32(TextKilometros.Text);
        }
        catch (Exception) { completado = false; negativo += "\n-Kilometros vacio o no es numero"; }

    }

    protected void ButtonRegistra_Click(object sender, EventArgs e)
    {
        validar();

        if (completado == true)
        {
            Boolean terminar = true;

            do
            {
                try
                {

                    int longitud = 7;
                    const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    String token = "";
                    Random rnd = new Random();

                    for (int i = 0; i < longitud; i++)
                    {
                        int indice = rnd.Next(alfabeto.Length);
                        token += alfabeto[indice];
                    }

                    String LLENAR = "INSERT INTO dbo.ruta(Clave, Provincia, IniRuta, FinRuta, Rural, Km)values('";
                    LLENAR += token + "'," + "'" + provincia + "'," + "'" + inicioR + "'," + "'" + finR + "'," + "'" + rural + "'," + kilometros + ")";
                    ServiceConexionR.ServiciosRutasClient WD = new ServiceConexionR.ServiciosRutasClient();
                    DataSet data = WD.FillDataRuta(LLENAR);

                    string ESPECIFICO = "select * from dbo.ruta where Clave='" + token + "'";
                    ServiceConexionR.ServiciosRutasClient WS = new ServiceConexionR.ServiciosRutasClient();
                    DataSet data1 = WS.GetRutaEspecifico(ESPECIFICO);
                    TextMostrar.DataSource = data1.Tables[0];
                    TextMostrar.DataBind();

                    terminar = true;
                }
                catch (Exception h)
                {
                    terminar = false;
                    throw new Exception(h.ToString());
                }

            } while (terminar == false);

            ResultadoOperacion.Text = "Agregado exitosamente";
            vaciarDatos();
        }
        else
        {
            ResultadoOperacion.Text = "Datos erroneos";
        }

    }


    protected void TextBuscar_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ButtonEliminar_Click(object sender, EventArgs e)
    {

    }

    protected void VerTodos_Click(object sender, EventArgs e)
    {
        ServiceConexionR.ServiciosRutasClient WD = new ServiceConexionR.ServiciosRutasClient();
        DataSet data = WD.GetAllRuta();
        int mayor = TextMostrar.Rows.Count;

        if (mayor >= 0)
        {
            TextMostrar.DataSource = data.Tables[0];
            TextMostrar.DataBind();
            ResultadoOperacion.Text = "Mostrando todos \n los buses";

        }
        else
        {
            ResultadoOperacion.Text = "Base de datos \n vacia";
        }
    }

    protected void ButtonElimina_Click(object sender, EventArgs e)
    {
        try
        {

            string ELIMINAR = "DELETE FROM dbo.ruta WHERE Clave='" + TextClave.Text + "'";
            ServiceConexionR.ServiciosRutasClient WD = new ServiceConexionR.ServiciosRutasClient();

            DataSet data = WD.EraseDataRuta(ELIMINAR);

            ServiceConexionR.ServiciosRutasClient WS = new ServiceConexionR.ServiciosRutasClient();
            DataSet data1 = WS.GetAllRuta();

            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();
            ResultadoOperacion.Text = "Eliminacion ruta completa";

            vaciarDatos();

        }
        catch (Exception d)
        {

            ResultadoOperacion.Text += "No existe esa ruta";

        }
    }
}
