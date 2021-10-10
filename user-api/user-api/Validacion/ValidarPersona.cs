using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;

namespace user_api.Validacion
{
    public class ValidarPersona
    {
        public void validarInformacion(PersonasDto persona)
        {

            if (!ValidarRun.ValidaRut(persona.Run))
            {
                throw new Exception("Ingrese un Run valido");
            }
            if (persona.Nombres.Equals(""))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (persona.ApellidoPaterno.Equals(""))
            {
                throw new Exception("El apellido paterno es obligatorio");
            }
            if (persona.ApellidoMaterno.Equals(""))
            {
                throw new Exception("El apellido materno es obligatorio");
            }
            if (!ValidarEmail.email_bien_escrito(persona.Email))
            {
                throw new Exception("Ingrese un email valido");
            }
            if (persona.SexoCodigo == 0)
            {
                throw new Exception("Seleccione un sexo");
            }
            if (persona.FechaNacimiento.Equals(""))
            {
                throw new Exception("Ingrese alguna fecha");
            }
            if (persona.RegionCodigo == 0)
            {
                throw new Exception("Seleccione una region");
            }
            if (persona.CiudadCodigo == 0)
            {
                throw new Exception("Seleccione una ciudad");
            }
            if (persona.ComunaCodigo == 0)
            {
                throw new Exception("Selecione una comuna");
            }
            if (persona.Direccion.Equals(""))
            {
                throw new Exception("Ingrese una direccion");
            }
            if (persona.Telefono.Equals(""))
            {
                throw new Exception("Ingrese un numero de telefono");
            }
            if (persona.Observaciones.Equals(""))
            {
                throw new Exception("Ingrese una observacion");
            }
        }
    }
}
