using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceFlight;

namespace WhixerShipments.Facade
{
    public static class ServiceFlightFacade
    {
        public static bool Ping()
        {
            ServiceFlightClient client = null;
            try
            {
                client = new ServiceFlightClient();
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
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
