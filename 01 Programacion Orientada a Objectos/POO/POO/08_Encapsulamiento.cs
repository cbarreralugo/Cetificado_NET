using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Encapsulamiento
    {
        public void main()
        {
            string cadena_GET_SET = "Este Texto Ya No Tiene Espacios, Gracias   Al    Encapsulamiento!!";
            Console.WriteLine(EliminarEspacios(cadena_GET_SET));
            string cadena_GET = "Mi nombre es Carlos";
            Console.WriteLine(Contar(cadena_GET));
        }

        private string EliminarEspacios(string texto)
        {
            var test = new ValidarCadena();
            test.Texto = texto;
            var resultado = test.Texto;
            return resultado;
        }
        private string Contar(string texto)
        {
            var test = new ValidarCadena();
            test.TextoParaConteo = texto;
            var resultado = test.Conteo;
            return resultado;
        }
    }
    public class ValidarCadena()
    {
        /*
         Encapsulamos el vamor de texto, para guardar un valor diferente en la privada al momento de asignacion del valor del publico
        
         */
        private string _Texto;
        public string Texto
        {
            //Al tener get y set, nos dice que es de lectura y escritura, por lo que podemos leer y retornar el valor modificado
            get { return _Texto; }
            set { _Texto = value.Replace(" ", ""); }
        }

        public string TextoParaConteo;
        public string Conteo
        {
            //Al tener solo get, indicamos que solo es lectura, por lo que no podemos modificar valor que esta resiviendo Conteo
            get { return $"Texto leido: {TextoParaConteo}, Total de caracteres: {TextoParaConteo.Length}"; }
        }
    }
}
