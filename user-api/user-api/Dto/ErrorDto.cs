using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Dto
{
    public class ErrorDto
    {
        public string Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
        
    }
}
