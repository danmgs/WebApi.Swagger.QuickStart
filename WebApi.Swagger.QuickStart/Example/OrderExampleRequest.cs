using Swashbuckle.AspNetCore.Filters;
using System;

namespace WebApi.Swagger.QuickStart.Model.Example
{
    public class OrderExampleRequest : IExamplesProvider<Order>
    {
        public Order GetExamples()
        {
            Random rnd = new Random();
            int i = Math.Abs(rnd.Next());
            return new Order()
            {
                Id = i,
                Label = $"Random order with qty {i}",
                Quantity = i
            };
        }
    }
}
