using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace user_api.Util
{
    public static class PersonaUtil
    {

        public static int formatearaRunCuerpo(string run)
        {
            string[] runFormateado = run.Split('-');
            return Convert.ToInt32(runFormateado[0].Replace(".",""));
        }

        public static string formatearaDigitoVerificador(string run)
        {
            string[] runFormateado = run.Split('-');
            return runFormateado[1];
        }



    }
}
