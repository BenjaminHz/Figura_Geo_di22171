using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    abstract class Figura //clase padre
    {
        /*clase va a permitir el ingresop de un lado, para poder crear
         * una nueva figura geometrica recuerda que una figura para poder
         * existir requiere minimo un lado esta clase es tipo abstrac es 
         * un molde, ella solo define el comportamiento de una figura*/

        /*declaramos las variables que se va pasrar a las clases hijas nos 
         * serviran para guardar en caja de memoria el valor del primer lado*/

        //la variable sera privada
        private float lado1;//permite decimales
        //creamos atributos o propiedades
        //definimos el constructor
        public float Lado1
        {
            /*metodo o modificador
             *para poner el valor (#)en la caja de memoria*/
            set //poner valor
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado1 =0;//manda el valor a 0
                }//no existen lados negativos
                else
                {
                    lado1 = value;
                    //value es el valor del textbox
                }
            }
            get//obtener el valor
            {
                return lado1;//regresa o cacha el valor de la variable Lado1
            }
        }

        //defino metodos, funciones, operaciones de la clase padre
        //que tambien van a tener los hijos
        //metodos de tipo publico para que todos los usen
        //metodos abstractos van vacios ya que cada hijo
        //definira sus operaciones
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
}
