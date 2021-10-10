using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;
using user_api.Entity;
using user_api.Util;

namespace user_api.Mapper
{
    public class UserMapper
    {
        

        public List<PersonasDto> mapearPersonas(List<Persona> personas)
        {

            return personas.Select(x => new PersonasDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Run = x.Run
            }).ToList();
                     
        }

        public Persona mapearPersona(PersonasDto personaDto)
        {

            return new Persona {
                Id = Guid.NewGuid(),
                //Run = personaDto.Run.ToString(),
                RunCuerpo = PersonaUtil.formatearaRunCuerpo(personaDto.Run.ToString()),
                RunDigito = PersonaUtil.formatearaDigitoVerificador(personaDto.Run.ToString()),
                //Nombre = personaDto.Nombre,
                Nombres = personaDto.Nombres,
                ApellidoPaterno = personaDto.ApellidoPaterno,
                ApellidoMaterno = personaDto.ApellidoMaterno,
                Email = personaDto.Email,
                SexoCodigo = personaDto.SexoCodigo,
                FechaNacimiento = personaDto.FechaNacimiento,
                RegionCodigo = personaDto.RegionCodigo,
                CiudadCodigo = personaDto.CiudadCodigo,
                ComunaCodigo = personaDto.ComunaCodigo,
                Direccion = personaDto.Direccion,
                Telefono = personaDto.Telefono,
                Observaciones = personaDto.Observaciones
            };
        }

        public Persona mapearPersonaParaEditar(PersonasDto personaDto)
        {

            return new Persona
            {
                Id = personaDto.Id,
                //Run = personaDto.Run.ToString(),
                RunCuerpo = PersonaUtil.formatearaRunCuerpo(personaDto.Run.ToString()),
                RunDigito = PersonaUtil.formatearaDigitoVerificador(personaDto.Run.ToString()),
                //Nombre = personaDto.Nombre,
                Nombres = personaDto.Nombres,
                ApellidoPaterno = personaDto.ApellidoPaterno,
                ApellidoMaterno = personaDto.ApellidoMaterno,
                Email = personaDto.Email,
                SexoCodigo = personaDto.SexoCodigo,
                FechaNacimiento = personaDto.FechaNacimiento,
                RegionCodigo = personaDto.RegionCodigo,
                CiudadCodigo = personaDto.CiudadCodigo,
                ComunaCodigo = personaDto.ComunaCodigo,
                Direccion = personaDto.Direccion,
                Telefono = personaDto.Telefono,
                Observaciones = personaDto.Observaciones
            };
        }

        public PersonasDto mapearPersonaAPersonaDto(Persona persona)
        {
            return new PersonasDto
            {
                Id = persona.Id,
                Run = persona.Run.ToString(),
                RunCuerpo = PersonaUtil.formatearaRunCuerpo(persona.Run.ToString()),
                RunDigito = PersonaUtil.formatearaDigitoVerificador(persona.Run.ToString()),
                Nombre = persona.Nombre,
                Nombres = persona.Nombres,
                ApellidoPaterno = persona.ApellidoPaterno,
                ApellidoMaterno = persona.ApellidoMaterno,
                Email = persona.Email,
                SexoCodigo = persona.SexoCodigo,
                FechaNacimiento = persona.FechaNacimiento,
                RegionCodigo = persona.RegionCodigo,
                CiudadCodigo = persona.CiudadCodigo,
                ComunaCodigo = persona.ComunaCodigo,
                Direccion = persona.Direccion,
                Telefono = persona.Telefono,
                Observaciones = persona.Observaciones
            };
        }


    }
}
