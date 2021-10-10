using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using user_api.Dto;
using user_api.Entity;
using user_api.Util;

namespace user_api.Repository
{
    public class UserRepository : IUserRepository
    {
        private PruebaTecnicaContext db = new PruebaTecnicaContext();

        public int editarPersona(Guid id,Persona persona)
        {
            var personaEditar = (from personadb in db.Personas where personadb.Id == id select personadb).FirstOrDefault();

                personaEditar.RunCuerpo = persona.RunCuerpo;
                personaEditar.RunDigito = persona.RunDigito.ToString();
                personaEditar.Nombres = persona.Nombres;
                personaEditar.ApellidoPaterno = persona.ApellidoPaterno;
                personaEditar.ApellidoMaterno = persona.ApellidoMaterno;
                personaEditar.Email = persona.Email;
                personaEditar.SexoCodigo = persona.SexoCodigo;
                personaEditar.FechaNacimiento = persona.FechaNacimiento;
                personaEditar.RegionCodigo = persona.RegionCodigo;
                personaEditar.CiudadCodigo = persona.CiudadCodigo;
                personaEditar.ComunaCodigo = persona.ComunaCodigo;
                personaEditar.Direccion = persona.Direccion;
                personaEditar.Telefono = persona.Telefono;
                personaEditar.Observaciones = persona.Observaciones;

                db.Entry(personaEditar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return db.SaveChanges();
                
                
        }

        public Persona obtenerPersona(Guid id)
        {
            return (from personadb in db.Personas where personadb.Id == id select personadb).FirstOrDefault();
        }

        public List<Persona> getUsers()
        {
            return (from personasdb in db.Personas select personasdb).ToList();        
        }

        public int guardarPersona(Persona persona)
        {
            
            db.Personas.Add(persona);
            return db.SaveChanges();
        }

        public int eliminarPersona(Guid id)
        {
            Persona personaEliminada = (from personadb in db.Personas where personadb.Id == id select personadb).FirstOrDefault();

            db.Remove(personaEliminada);
            return db.SaveChanges();
        }

        public List<Region> obtenerRegiones()
        {
            
            List<Region> regiones = (from regionDb in db.Regions select regionDb).ToList();

            return regiones;
        }

        public List<Ciudad> obtenerCiudades(int id)
        {
            List<Ciudad> ciudades = (from ciudadDb in db.Ciudads
                                   where ciudadDb.RegionCodigo == id
                                   select ciudadDb).ToList();
            return ciudades;
        }

        public List<Comuna> obtenerComunas(int id)
        {
            List<Comuna> comunas = (from comunasDb in db.Comunas
                                     where comunasDb.CiudadCodigo == id
                                     select comunasDb).ToList();
            return comunas;
        }
    }
}
