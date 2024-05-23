using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class Esfera:Figura
    {
        public Esfera(float rad)
        {
           this. Lado1 = rad;
        }
        public override float area()
        {
            return 4*3.1416F * (2 * Lado1);
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            return 4 / 3 * 3.1416F * (3 * Lado1);
        }
    }
}
