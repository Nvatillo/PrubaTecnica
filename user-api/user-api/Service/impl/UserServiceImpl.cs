using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;
using user_api.Entity;
using user_api.Mapper;
using user_api.Repository;

namespace user_api.Service.impl
{
    public class UserServiceImpl : IUserService
    {

        private UserRepository userRepository = new UserRepository();
        private UserMapper mapper = new UserMapper();

        public void editarPersona(Guid id,PersonasDto persona)
        {
            Persona personaMapeada = mapper.mapearPersonaParaEditar(persona);
            if (userRepository.editarPersona(id, personaMapeada) != 1)
            {
                throw new Exception("Ocurrio un problema al editar, porfavor intente mas tarde");
            }
           
        }

        public int eliminarPersona(Guid id)
        {
            return userRepository.eliminarPersona(id);
        }

        public List<PersonasDto> getUsers()
        {
            List<Persona> personas = userRepository.getUsers();
            userRepository.obtenerRegiones();
            return mapper.mapearPersonas(personas);

        }


        public void guardarPersona(PersonasDto personaDto)
        {
            Persona persona = mapper.mapearPersona(personaDto);
            if (userRepository.guardarPersona(persona) != 1)
            {
                throw new Exception("Ocurrio un problema al guardar, porfavor intente mas tarde");
            }
             
        }

        public PersonasDto obtenerPersona(Guid id)
        {
            Persona persona = userRepository.obtenerPersona(id);

            return mapper.mapearPersonaAPersonaDto(persona);
        }

        public List<RegionDto> obtenerRegiones()
        {
            List<Region> regiones =  userRepository.obtenerRegiones();
            List<RegionDto> regionDtos = regiones.Select(region => new RegionDto {
                Codigo = region.Codigo,
                Nombre = region.Nombre,
                NombreOficial = region.NombreOficial,
                CodigoLibroClaseElectronico = region.CodigoLibroClaseElectronico,
                Ciudads = userRepository.obtenerCiudades(region.Codigo).Select(r => new CiudadDto
                {
                    Codigo = r.Codigo,
                    Nombre = r.Nombre,
                    Comunas = userRepository.obtenerComunas(r.Codigo).Select(c => new ComunaDto
                    {
                        Nombre = c.Nombre,
                        Codigo = c.Codigo
                    }).ToList()
                }).ToList()

            }).ToList();
           
            return regionDtos;
        }
    }
}
