using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WhixerShipments.BusinessLogic;
using WhixerShipments.Services.Interfaces;

namespace WhixerShipments.Services
{
    public class ServiceWantToTake : IServiceWantToTake
    {
        public bool Ping()
        {
            return ManagerWantToTake.Ping();
        }
    }
}
