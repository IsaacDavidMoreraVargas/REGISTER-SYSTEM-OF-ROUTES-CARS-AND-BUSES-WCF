using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSERVIDOR
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiciosRutas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiciosRutas
    {
        [OperationContract, WebGet(UriTemplate = "GetAllRuta")]
        DataSet GetAllRuta();

        [OperationContract, WebGet(UriTemplate = "FillDataRuta")]
        DataSet FillDataRuta(string instruccionLlenar);

        [OperationContract, WebGet(UriTemplate = "EraseDataRuta")]
        DataSet EraseDataRuta(string instruccionEliminar);

        [OperationContract, WebGet(UriTemplate = "GetRutaEspecifico")]
        DataSet GetRutaEspecifico(string instruccionEspecifico);
    }
}
