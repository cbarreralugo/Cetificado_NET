using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Clases_y_Objectos
    {
        //CLASES Y OBJECTOS
        public void main()
        {
            var variable = 0; //var avarca todos los tipos de datos, C# identifica el tipo de dato en automatico
            Apuntador apuntadorPlatzi = new Apuntador(); //Objecto
            Apuntador apuntadorPlatzi2 = new Apuntador(); //Objecto

            apuntadorPlatzi.Color = "Negro";
            apuntadorPlatzi2.Color = "Blanco";
        }
    }
    class Apuntador
    {
        public string Color; //Cadenas
        public double Tamaño; //Desimales
        public short NumeroDeBotones; //Números enteros cortos
        public bool TieneStickers; //Bandera
    }
}
