using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WhixerShipments.Facade;

namespace WhixerShipments.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public bool Ping()
        {
            return ServiceUserFacade.Ping();
        }
    }
}
