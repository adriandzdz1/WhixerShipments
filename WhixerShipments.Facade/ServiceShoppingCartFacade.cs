﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WhixerShipments.Facade.ServiceMap;
using WhixerShipments.Facade.ServiceShoppingCart;

namespace WhixerShipments.Facade
{
    public static class ServiceShoppingCartFacade
    {
        public static bool Ping()
        {
            ServiceShoppingCartClient client = null;
            try
            {
                client = new ServiceShoppingCartClient();
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
