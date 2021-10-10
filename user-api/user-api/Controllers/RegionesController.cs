using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;
using user_api.Service.impl;

namespace user_api.Controllers
{
    [ApiController]
    [Route("regiones")]
    public class RegionesController : BaseController
    {
        static UserServiceImpl service = new UserServiceImpl();
        [HttpGet]
        public ActionResult<List<RegionDto>> obtenerRegiones()
        {
            return service.obtenerRegiones();
        }
    }
}
