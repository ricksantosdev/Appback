using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.ApplicationCore.Entity;
using App.ApplicationCore.Interfaces.Services;
using App.ApplicationCore.Services;
using App.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace App.ApplicationAPI.Controllers
{
    [Route("api")]
    [Produces("application/json")]
    [ApiController]
    [EnableCors()]
    public class ClientController : ControllerBase
    {
        private IClientServices _clientServices;
        public ClientController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }


        /// <summary>
        /// Obtendo dados de Cliente por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("client/getCLient/{id}")]
        [HttpGet]
        public JsonResult Get(int id)
        {
            var resul = _clientServices.GetEntityById(id);

            return new JsonResult(resul);
        }


    }


}
