using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Dto
{
    public class CiudadDto
    {
        public short RegionCodigo { get; set; }
        public short Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ComunaDto> Comunas { get; set; }
    }
}
