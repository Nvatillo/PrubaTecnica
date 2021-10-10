using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Dto
{
    public class ComunaDto
    {
        
            public short RegionCodigo { get; set; }
            public short CiudadCodigo { get; set; }
            public short Codigo { get; set; }
            public string Nombre { get; set; }
            public int CodigoPostal { get; set; }
            public int CodigoLibroClaseElectronico { get; set; }

            public virtual CiudadDto Ciudad { get; set; }
            public virtual ICollection<PersonasDto> Personas { get; set; }

        }
}
