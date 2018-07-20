using System.Linq;
using System.Collections.Generic;
using WebApi.Swagger.QuickStart.Model;
using WebApi.Swagger.QuickStart.Services.Interfaces;

namespace WebApi.Swagger.QuickStart.Services
{
    public class OrderService : IOrderService
    {
        List<Order> _orderMockDataSet = new List<Order>() {
                                            new Order() { Id = 1, Label = "Order1", Quantity = 10 },
                                            new Order() { Id = 2,  Label = "Order2", Quantity = 20 },
                                            new Order() { Id = 3, Label = "Order3", Quantity = 30 }
                                        };

        public IEnumerable<Order> Get()
        {
            return _orderMockDataSet;
        }

        public Order Get(int id)
        {
            return _orderMockDataSet.FirstOrDefault(o => o.Id.Equals(id));
        }
    }
}
