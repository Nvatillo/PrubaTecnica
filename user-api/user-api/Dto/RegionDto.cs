using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Dto
{
    public class RegionDto
    {
        public short Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreOficial { get; set; }
        public int CodigoLibroClaseElectronico { get; set; }

        public virtual ICollection<CiudadDto> Ciudads { get; set; }
    }
}
