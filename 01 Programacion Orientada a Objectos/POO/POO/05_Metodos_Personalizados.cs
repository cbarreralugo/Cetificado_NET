using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    //METODOS PERSONALIZADOS
    public class Metodos_Personalizados
    {
        /*
         Metodos dentro de metodos para trabajar la logica que puede o no retornar un resultado, un claro ejemplo de uso son en los CRUD
        La palabra reservada void indica que es un metodo de logica
         */
        public void main()
        {
            var resultado = Calcular(Tablero(),Operacion.Suma);
            ImprimirMensaje(resultado.ToString());
        }

        public double Calcular(string[] valores,Operacion operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case Operacion.Suma:
                    resultado = double.Parse(valores[0]) + double.Parse(valores[1]);
                    break;
                case Operacion.Resta:
                    resultado = double.Parse(valores[0]) - double.Parse(valores[1]);
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        public string[] Tablero()
        {
            string[] valores = new string[2] ;
            Console.WriteLine("Ingresa un número:");
            var dato1 = Console.ReadLine();
            Console.WriteLine("Ingresa un segúndo valor:");
            var dato2 = Console.ReadLine(); 
            valores[0] = dato1.ToString();
            valores[1]= dato2.ToString();
            return valores ;
        }

        public void ImprimirMensaje(string texto)
        {
            Console.WriteLine(texto);
        }

        public enum Operacion
        {
            Suma,
            Resta
        }
    }
}
