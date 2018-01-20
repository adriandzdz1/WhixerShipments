using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WhixerShipments.Services.Interfaces
{
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        bool Ping();
    }
}
