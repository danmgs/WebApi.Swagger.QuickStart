using System.Linq;
using System.Collections.Generic;
using WebApi.Swagger.QuickStart.Model;
using WebApi.Swagger.QuickStart.Services.Interfaces;
using WebApi.Swagger.QuickStart.DAL;

namespace WebApi.Swagger.QuickStart.Services
{
    public class OrderService : IOrderService
    {
        public IEnumerable<Order> Get()
        {
            return OrderStorageManager.Get();
        }

        public Order Get(int id)
        {
            return OrderStorageManager.Get(id);
        }

        public bool Add(Order order)
        {
            return OrderStorageManager.Add(order);
        }

        public bool Modify(Order order)
        {
            return OrderStorageManager.Modify(order);
        }

        public bool Delete(int id)
        {
            return OrderStorageManager.Delete(id);
        }
    }
}
