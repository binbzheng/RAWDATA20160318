using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;

namespace Web.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IRepository _repository = new MySqlRepository();

        public IHttpActionResult Get()
        {
            var data = _repository.GetOrders();
            return Ok(data);
        }

    }
}
