using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Swagger.QuickStart.Model;

namespace WebApi.Swagger.QuickStart.Services.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> Get();
        Order Get(int id);
        bool Add(Order order);
        bool Modify(Order order);
        bool Delete(int id);
    }
}
