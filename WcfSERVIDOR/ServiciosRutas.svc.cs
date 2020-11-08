using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfSERVIDOR
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiciosRutas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiciosRutas.svc o ServiciosRutas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiciosRutas : IServiciosRutas
    {

        public DataSet EraseDataRuta(string instruccionEliminar)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01; Initial Catalog=DATABUSANDRUTA; Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionEliminar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);


            return datasetLLamado;
        }

        public DataSet FillDataRuta(string instruccionLlenar)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01; Initial Catalog=DATABUSANDRUTA; Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionLlenar, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            return datasetLLamado;
        }

        public DataSet GetAllRuta()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01; Initial Catalog=DATABUSANDRUTA; Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter("SELECT * FROM dbo.ruta", conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            return datasetLLamado;
        }

        public DataSet GetRutaEspecifico(string instruccionEspecifico)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PROGRA-14\\MSSQLSERVER01; Initial Catalog=DATABUSANDRUTA; Integrated Security=True";
            SqlDataAdapter llamadoLenar = new SqlDataAdapter(instruccionEspecifico, conn);
            DataSet datasetLLamado = new DataSet();
            llamadoLenar.Fill(datasetLLamado);
            return datasetLLamado;
        }
    }
}
