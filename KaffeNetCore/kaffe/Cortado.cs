using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class Cortado : Kaffe , Imælk
    {
        /// <summary>
        /// hvor meget mælk skal bruge i cortado
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 25;
        }

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            int prisMedRabat = 25 - Rabat;

            if (prisMedRabat <= 0)
            {
                throw new ArgumentException("Too much rabat man, way too much");
            }

            return prisMedRabat;
        }

        public Cortado() : base()
        {
            
        }

        public Cortado(int rabat) : base(rabat)
        {
            
        }
    }
}
