using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bus : System.Web.UI.Page
{
    int pasajerosPie = 0;
    int pasajeroSentados = 0;
    string ruta = " ";

    string provincia = " ";
    string inscrito = " ";
    string autorizado = " ";

    protected void Page_Load(object sender, EventArgs e)
    {

        ServiceConexionB.IServicioBusClient WS = new ServiceConexionB.IServicioBusClient();
        DataSet data1 = WS.GetAllBusesData();
        int mayor = TextMostrar.Rows.Count;

        if (mayor >= 0)
        {
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();
            ResultadoOperacion.Text = "Mostrando todos \n los buses";

        }
        else
        {
            ResultadoOperacion.Text = "Base de datos \n vacia";
        }

    }

    public void vaciarDatos()
    {
        TextClave.Text = "";
        DropProvincia.Text = "---";
        TextRuta.Text = "";
        DropInscrito.Text = "---";
        DropAutorizado.Text = "--";
        TextPaSentados.Text = "";
        TextPaPie.Text = "";
    }

    Boolean correcto = true;
    string negativo = "";

    public void validar()
    {
        if (DropProvincia.Text == "---")
        {
            correcto = false;
            negativo += "\n - Provincia vacio";
        }
        else
        {
            provincia = DropProvincia.Text;

        }

        if (TextRuta.Text.Length > 7)
        {
            negativo += "\n-Ruta mayor a 7 digitos";
            correcto = false;
        }
        else
        {
            ruta = TextRuta.Text;
        }

        if (TextRuta.Text.Length <= 0)
        {
            negativo += "\n-Ruta vacio";
            correcto = false;
        }
        else
        {
            ruta = TextRuta.Text;
        }

        if (TextRuta.Text == " ")
        {
            negativo += "\n-Ruta vacio";
            correcto = false;
        }
        else
        {
            ruta = TextRuta.Text;
        }


        if (DropInscrito.Text == "---")
        {
            correcto = false;
            negativo += "\n - Inscrito vacio";
        }
        else
        {
            inscrito = DropInscrito.Text;

        }

        if (DropAutorizado.Text == "---")
        {
            correcto = false;
            negativo += "\n - Autorizado Vacio ";
        }
        else
        {
            autorizado = DropAutorizado.Text;
        }

        try
        {
            pasajeroSentados = Convert.ToInt32(TextPaSentados.Text);

        }
        catch (Exception) { correcto = false; negativo += "\n - Cantidad pasajeros sentados vacio o no es numero"; };


        try
        {
            pasajerosPie = Convert.ToInt32(TextPaPie.Text);

        }
        catch (Exception) { correcto = false; negativo += "\n - Cantidad pasajeros pie vacio o no es numero "; };

    }

    protected void ButtonRegista_Click(object sender, EventArgs e)
    {

        validar();


        if (correcto == true)
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

                    String LLENAR = "INSERT dbo.buses(Clave,Provincia, Ruta, Inscrito, Autorizado, Sentados, Pie)values('";
                    LLENAR += token + "'," + "'" + provincia + "'," + "'" + ruta + "'," + "'" + inscrito + "'," + "'" + autorizado + "'," + "'" + pasajeroSentados.ToString() + "'," + "'" + pasajerosPie.ToString() + "')";
                    ServiceConexionB.IServicioBusClient WD = new ServiceConexionB.IServicioBusClient();
                    DataSet data = WD.FillDataBus(LLENAR);

                    string ESPECIFICO = "select * from dbo.buses where Clave='" + token + "'";
                    ServiceConexionB.IServicioBusClient WS = new ServiceConexionB.IServicioBusClient();
                    DataSet data1 = WS.GetBusEspecifico(ESPECIFICO);
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Enabled = true;
        ButtonRegista.Enabled = true;
        VerTodos.Enabled = true;
        Editar.Enabled = true;
        correcto = true;
        validar();
        TextClave.Text.ToUpper();

        if (correcto == true)
        {
            String Editar = "UPDATE dbo.buses SET Clave ='" + TextClave.Text + "', Provincia ='" + provincia + "', Ruta = '" + ruta + "', Inscrito = '" + inscrito + "', Autorizado = '" + autorizado + "', Sentados = '" + pasajeroSentados.ToString() + "', Pie = '" + pasajerosPie.ToString() + "'  WHERE Clave = '" + TextClave.Text + "'";
            ServiceConexionB.IServicioBusClient WD = new ServiceConexionB.IServicioBusClient();
            DataSet data = WD.EditDataBus(Editar);

            string ESPECIFICO = "select * from dbo.buses where Clave='" + TextClave.Text + "'";
            ServiceConexionB.IServicioBusClient WS = new ServiceConexionB.IServicioBusClient();
            DataSet data1 = WS.GetBusEspecifico(ESPECIFICO);
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();

            ResultadoOperacion.Text = "Actualizado \n exitosamente";
            vaciarDatos();
        }
        else
        {
            ResultadoOperacion.Text = "Datos erroneos";

        }

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        ButtonRegista.Enabled = false;
        VerTodos.Enabled = false;

        try
        {

            string ESPECIFICO = "select * from dbo.buses where Clave='" + TextClave.Text + "'";
            ServiceConexionB.IServicioBusClient WS = new ServiceConexionB.IServicioBusClient();
            DataSet data1 = WS.GetBusEspecifico(ESPECIFICO);
            TextMostrar.DataSource = data1.Tables[0];
            TextMostrar.DataBind();
            DropProvincia.Text = TextMostrar.Rows[0].Cells[1].Text;
            TextRuta.Text = TextMostrar.Rows[0].Cells[2].Text;
            DropInscrito.Text = TextMostrar.Rows[0].Cells[3].Text;
            DropAutorizado.Text = TextMostrar.Rows[0].Cells[4].Text;
            TextPaSentados.Text = TextMostrar.Rows[0].Cells[5].Text;
            TextPaPie.Text = TextMostrar.Rows[0].Cells[6].Text;

            ResultadoOperacion.Text = "-Bus encontrado \n -Puede editar datos en espacios luego pinche boton 'EDITAR'";

        }
        catch (Exception r)
        {
            ResultadoOperacion.Text = "No existe ID";
        };
    }

    protected void VerTodos_Click(object sender, EventArgs e)
    {
        Button1.Enabled = true;
        ButtonRegista.Enabled = true;
        VerTodos.Enabled = true;
        Editar.Enabled = true;

        ServiceConexionB.IServicioBusClient WS = new ServiceConexionB.IServicioBusClient();
        DataSet data1 = WS.GetAllBusesData();
        TextMostrar.DataSource = data1.Tables[0];
        TextMostrar.DataBind();

        ResultadoOperacion.Text = "Todos los \nbuses mostrados";
    }
}
