using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    /*
    POO:
    Se basan en propiedades que representan las caracteristicas del objecto y mpetodos que definen el comportamientos
    Las clases tienen metodo, o funciones ( que definen  el comportamiento de la clase)
    Podemos decir que las clases son como plantillas, o moldes que podemos reutilizar.
    Los objectos son instancias de las clases, ya que hacen referencia de la clase
    Las Clases contienen Metodos y Propiedades
     */

    public class Clases_y_Propiedades
    {
        //CLASES Y PROPIEDADES
        public void main()
        {
            Cafetera apuntadorCafetera = new Cafetera();
            apuntadorCafetera.Color = "Negro";
            apuntadorCafetera.Tamaño = 14.3;
            apuntadorCafetera.Filtro = true;
            apuntadorCafetera.Marca = "Oster";
            apuntadorCafetera.ImprimirCafetera(apuntadorCafetera);
        }
    }

    public class Cafetera
    {
        //Propiedades
        public double Tamaño { get; set; }
        public string Color { get; set; }
        public bool Filtro { get; set; }
        public string Marca { get; set; }

        //Metodo
        public void ImprimirCafetera(Cafetera cafetera)
        {
            Console.WriteLine($"Tamaño: {cafetera.Tamaño}\n" +
                $"Color: {cafetera.Color}\n" +
                $"Usa filtro: {cafetera.Filtro}\n" +
                $"Marca: {cafetera.Marca}");
        }
    }
}
