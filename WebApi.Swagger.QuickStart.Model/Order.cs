using System;

namespace WebApi.Swagger.QuickStart.Model
{
    public class Order : IEquatable<Order>
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Quantity { get; set; }

        public bool Equals(Order other)
        {
            return this.Id == other.Id;
        }
    }
}
