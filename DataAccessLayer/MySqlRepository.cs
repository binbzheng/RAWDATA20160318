using System.Collections.Generic;
using DomainModel;

namespace DataAccessLayer
{
    public class MySqlRepository : IRepository
    {


        public IEnumerable<Order> GetOrders()
        {
            return  new List<Order>
            {
                new Order {Id = 1 },
                new Order {Id = 2 },
                new Order {Id = 3 },
                new Order {Id = 4 },
                new Order {Id = 5 }
            };
        }
    }
}