using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDeterminated(double a)
        {
            bool risposta = true;
            if(a == 0)
            {
                risposta = false;
            }
            return risposta;
        }
    }
}
