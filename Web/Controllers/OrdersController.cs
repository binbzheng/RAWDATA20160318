using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class OrdersController : ApiController
    {

        public IHttpActionResult Get()
        {
            var data = new
            {
                Name = "David",
                Age = 21
            };

            return Ok(data);
        }

    }
}
