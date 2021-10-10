using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using user_api.Dto;
using user_api.Service.impl;
using user_api.Validacion;



namespace user_api.Controllers
{
    [ApiController]
    [Route("personas")]
    public class PersonasController : BaseController
    {

        static UserServiceImpl service = new UserServiceImpl();
        static ValidarPersona validacion = new ValidarPersona();

        [HttpGet]
        public ActionResult<List<PersonasDto>> getUsers()
        {
           return service.getUsers();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void guardarPersona(PersonasDto persona)
        {
            validacion.validarInformacion(persona);
            service.guardarPersona(persona);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public void editarPersona(Guid id , PersonasDto persona)
        {
            validacion.validarInformacion(persona);
            service.editarPersona(id,persona);
        }

        [HttpGet("{id}")]
        public ActionResult<PersonasDto> obtenerPesona(Guid id)
        {
            return service.obtenerPersona(id);
        }

        [HttpDelete("{id}")]
        public void eliminarPersona(Guid id)
        {
            service.eliminarPersona(id);
        }
        


    }

    
}
