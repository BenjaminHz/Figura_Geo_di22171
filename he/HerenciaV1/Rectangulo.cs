using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class Rectangulo:Figura
    {
        //esta clase requiere dos lados para funcionar
        //creamos el lado2
        private float lado2;
        //crear un constructor para rectangulo
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0;//manda el valor =0
                }//no existe lados negativos
                else
                {
                    {
                        lado2 = value;
                        //value es el valor del textbox

                    }
                }
            }
            get
            {
                return lado2;//regresa o cacha el calor de las variables
            }
        }
        //usamos el constructor de la clase padre
        public Rectangulo(float lado1,float lado2)
        {
            //Lado1 y lado 2 se va a leer de la caja de texto
            //usando el boton guardar
            this.Lado1 = lado1; //hace que unicamente el valor la cantidad del lado sea disponible para cada 
            //rectangulo, cuando se une rectangulo
            this.Lado2 = lado2;
        }
        //vamos a usar los metodos de la clase padre
        //vamos a sobreescribir el comportamiento de estos
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //esto es una execsion de uso defaul del sistema
        }
    }
}
