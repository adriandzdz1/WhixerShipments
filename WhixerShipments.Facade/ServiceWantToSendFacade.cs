using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceUser;
using WhixerShipments.Facade.ServiceWantToSend;

namespace WhixerShipments.Facade
{
    public static class ServiceWantToSendFacade
    {
        public static bool Ping()
        {
            ServiceWantToSendClient client = null;
            try
            {
                client = new ServiceWantToSendClient();
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
