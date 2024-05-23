using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class PoligonoReg:Figura
    {
        //declarar dos valores float para guardar numero de lados
        //y el apotema privado para usarse solo en esta clase
        private float apotema, n;
        public float Apotema
        {
            set
            {
                //pregunta si el apotema(es el # del centro del poligono)<0
                if (value <= 0)
                {
                    apotema = 0;//manda el valor a 0
                    //NO EXISTE APOTEMAS NEGATIVOS
                }
                else
                {
                    apotema = value;//value es el valor del texbox
                }
            }
            get//obtener valor
            {
                return apotema;//regreso o cacha el valor de la variable apotema
            }
        }
        public float N
        {
            set
            {
                if (value <5)
                {
                    n = 5;
                }
                else
                {
                    n = value;
                }
            }
            get
            {
                return n;
            }
        }
        public PoligonoReg(float lado,float apotema,float n)
        {//radio se va leer de la caja de texto con
            //usando el boton guardar
            this.Lado1 = lado;
            this.Apotema = apotema;
            this.N = n;
        }
        public float area(float peri)
        {
            return (peri * apotema) / 2;
        }
        public override float perimetro()
        {
            float peri;
            peri = n * Lado1;
            return peri;
        }
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
