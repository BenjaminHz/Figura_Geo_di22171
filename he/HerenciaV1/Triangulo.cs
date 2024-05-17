using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaV1
{
    class Triangulo : Figura//conectamos que es hija de la clase padre que seria figura
    {
        public Triangulo(float Bas) //se crea la base del triangulo
        {
            Lado1 = Bas; //se pide, lo que se meta Bas se ira a guardar al Laso1
        }
        private float Alt;//creamos la altura
        public float alt
        {//aca es como recibira la informacion y lanzara
            set
            {
                if (value < 0)
                {
                    Alt = 0;
                }
                else
                {
                    Alt = value;
                }//value es el valor del textbox
            }
            get
            {
                return Alt;
            }
        }
            public Triangulo(float Bas,float Alt)
        {//estos valores solo se utilizara en esta clase triangulo
            this.Lado1 = Bas;
            this.Alt = Alt;
        }//la funciones para encontrar el area, perimetro y volumen
        public override float area()
        {
            return (Lado1 * Alt) / 2;
        }
        public override float perimetro()
        {//el perimetro se saca sumando todos los lados
            return Lado1 + Alt + Alt;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }//es default del sistema

    }
    
}
