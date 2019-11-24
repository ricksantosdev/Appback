using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Services;
using App.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.ApplicationAPI.Controllers
{
    [Route("api")]
    // [Produces("application/json")]
    [ApiController]
    public class OrderController : Controller
    {

        private IOrderServices _orderServices;
        public OrderController(ApplicationContext context, IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        /// <summary>
        /// Obtendo o Pedido por Id
        /// </summary>
        /// <param name="idOrder"></param>
        /// <returns></returns>
        [Route("order/getOrder/{idOrder}")]
        [HttpGet]
        public IActionResult Get(int idOrder)
        {
            var order = _orderServices.GetEntityById(idOrder);

            return Ok(order);
        }

        /// <summary>
        /// Obtendo itens do pedido pelo Id Pedido
        /// </summary>
        /// <param name="idOrder"></param>
        /// <returns></returns>
        [Route("order/getList/{idOrder}")]
        [HttpGet]
        public IActionResult GetListItemOrder(int idOrder)
        {
            var orderProduct = _orderServices.GetProductOrder(idOrder);
            List<Product> prods = new List<Product>();

            foreach (var item in orderProduct)
            {
                prods.Add(item);
            }

            return Ok(prods);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Status"></param>
        [HttpPut("order/update/{id}")]
        public void Put(int id, [FromBody] string Status)
        {
            if (!String.IsNullOrEmpty(Status))
            {
                Order orderObject = _orderServices.GetEntityById(id);
                orderObject.Status = int.Parse(Status);

                _orderServices.UpdateEntity(orderObject);
            }

        }
    }
}