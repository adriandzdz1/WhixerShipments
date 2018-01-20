using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceFlight;
using WhixerShipments.Facade.ServiceMap;

namespace WhixerShipments.Facade
{
    public static class ServiceMapFacade
    {
        public static bool Ping()
        {
            ServiceMapClient client = null;
            try
            {
                client = new ServiceMapClient();
                client.Open();

                return client.Ping();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    if (client.State == CommunicationState.Faulted)
                    {
                        client.Abort();
                    }
                    else
                    {
                        client.Close();
                    }
                }
            }
        }
    }
}
