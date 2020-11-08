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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioBus" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIServicioBus
    {
        [OperationContract, WebGet(UriTemplate = "GetAllBusesData")]
        DataSet GetAllBusesData();

        [OperationContract, WebGet(UriTemplate = "FillDataBus")]
        DataSet FillDataBus(string instruccionLlenar);

        [OperationContract, WebGet(UriTemplate = "EditDataBus")]
        DataSet EditDataBus(string instruccionEditar);

        [OperationContract, WebGet(UriTemplate = "GetBusEspecifico")]
        DataSet GetBusEspecifico(string instruccionEspecifico);
    }
}
