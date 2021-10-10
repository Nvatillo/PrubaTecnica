using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;

namespace user_api.Service
{
    interface IUserService
    {
        List<PersonasDto> getUsers();

        void guardarPersona(PersonasDto persona);

        void editarPersona(Guid id,PersonasDto persona);

        PersonasDto obtenerPersona(Guid id);

        int eliminarPersona(Guid id);

        List<RegionDto> obtenerRegiones();
    }
}
