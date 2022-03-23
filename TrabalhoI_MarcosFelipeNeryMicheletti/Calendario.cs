using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoI_MarcosFelipeNeryMicheletti
{
    public class Calendario
    {
        public Byte mes { get; set; }
        private UInt16 ano { get; set; }

        public Boolean isMesValido()
        {
            if (mes > 12 || mes < 1)
            {
                return false;
            }
            else return true;
        }

    }
}
