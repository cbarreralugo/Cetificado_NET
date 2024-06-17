using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /*
     Una clase puede heredar metodos y propiedades a otra clase
    para identificar la herencia se usa el caracter : despues del nombre a la clase a heredar
    C# solo puede heredar de una clase
     */
    public class Herencia : Metodos_Personalizados
    {
        //Para este ejemplo usaremos el ejemplo 03 Metodos_Personalizados
        public void main()
        {
            var resultado = Calcular(Pasos(),Operacion.Resta);
            ImprimirMensaje($"Animo ya solo te faltan {resultado} pasos para llegar a tu meta!!");
        }

        private string[] Pasos()
        {
            string[] datos = new string[2];
            Console.WriteLine("Meta de número de pasos por hacer en el día:");
            var total = Console.ReadLine();
            Console.WriteLine("Cuantos pasos llevas?");
            var pasos = Console.ReadLine();
            datos[0] = total;
            datos[1]=pasos;
            return datos;
        }
    }
}
