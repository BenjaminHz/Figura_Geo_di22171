using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class Cuadrado:Figura
    {
      private float lado2;
        public float Lado2
        {
            set
            {
                if(value<0)
                {
                    lado2 = 0;
                }
                else
                {
                    lado2 = value;
                }
            }
            get
            {
                return lado2;
            }
        }
        public Cuadrado(float lado1, float lado2)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }
        public override float area()
        {
            return Lado1*Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
