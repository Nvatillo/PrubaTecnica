using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Entity;

namespace user_api.Repository
{
    interface IUserRepository
    {
        List<Persona> getUsers();

        int guardarPersona(Persona persona);

        int editarPersona(Guid id, Persona persona);

        Persona obtenerPersona(Guid id);

        int eliminarPersona(Guid id);

        List<Region> obtenerRegiones();

        List<Ciudad> obtenerCiudades(int id);

        List<Comuna> obtenerComunas(int id);
    }
}
