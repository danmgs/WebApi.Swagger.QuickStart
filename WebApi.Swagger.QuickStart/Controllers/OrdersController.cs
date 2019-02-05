using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Swagger.QuickStart.Model;
using WebApi.Swagger.QuickStart.Services.Interfaces;

namespace WebApi.Swagger.QuickStart.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        public IOrderService _orderService { get; set; }

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Gets all the orders
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET api/orders
        ///
        /// </remarks>
        /// <returns>All the orders</returns>
        /// <response code="200">Returns the orders</response>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.Get();
        }

        /// <summary>
        /// Gets an order given the id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET api/order/1
        ///
        /// </remarks>
        /// <param name="id">The order id</param>
        /// <returns>An order</returns>
        /// <response code="200">Returns the order</response>
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderService.Get(id);
        }

        // POST api/orders
        [HttpPost]
        public bool Post([FromBody]Order order)
        {
            return _orderService.Add(order);
        }

        // PUT api/orders/1
        [HttpPut]
        public bool Put([FromBody]Order order)
        {
            return _orderService.Modify(order);
        }

        // DELETE api/orders/1
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _orderService.Delete(id);
        }
    }
}
