using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceWantToSend;
using WhixerShipments.Facade.ServiceWantToTake;

namespace WhixerShipments.Facade
{
    public static class ServiceWantToTakeFacade
    {
        public static bool Ping()
        {
            ServiceWantToTakeClient client = null;
            try
            {
                client = new ServiceWantToTakeClient();
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
