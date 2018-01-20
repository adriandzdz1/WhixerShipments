using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceShoppingCart;
using WhixerShipments.Facade.ServiceUser;

namespace WhixerShipments.Facade
{
    public static class ServiceUserFacade
    {
        public static bool Ping()
        {
            ServiceUserClient client = null;
            try
            {
                client = new ServiceUserClient();
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
