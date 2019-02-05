using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Swagger.QuickStart.Model;

namespace WebApi.Swagger.QuickStart.DAL
{
    public static class OrderStorageManager
    {
        private static List<Order> Orders = new List<Order>() {
                                            new Order() { Id = 1, Label = "Order1", Quantity = 10 },
                                            new Order() { Id = 2,  Label = "Order2", Quantity = 20 },
                                            new Order() { Id = 3, Label = "Order3", Quantity = 30 }
                                        };

        public static IEnumerable<Order> Get()
        {
            return Orders;
        }

        public static Order Get(int id)
        {
            return Orders.Find(o => o.Id.Equals(id));
        }

        public static bool Add(Order order)
        {
            if (Get(order.Id) == null)
            {
                Order o = new Order()
                {
                    Id = order.Id,
                    Label = order.Label,
                    Quantity = order.Quantity
                };

                OrderStorageManager.Orders.Add(o);
                return true;
            }
            else return false;
        }

        public static bool Modify(Order order)
        {
            Order orderToModified = Get(order.Id);
            if (orderToModified != null)
            {
                orderToModified.Label = order.Label;
                orderToModified.Quantity = order.Quantity;
                return true;
            }
            return false;
        }

        public static bool Delete(int id)
        {
            Order o = new Order() { Id = id };
            return OrderStorageManager.Orders.Remove(o);
        }
    }
}
