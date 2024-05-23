using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class Cubo:Figura
    {
        public Cubo(float Ladoc)
        {
            this.Lado1 = Ladoc;
        }
        public override float area()
        {
            return 6 * Lado1;
        }
        public override float volumen()
        {
            return 3 * Lado1;
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }

    }
}
