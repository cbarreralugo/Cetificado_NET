using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    /*
    Las Clases se pueden usar en cual nivel de complejidad
    Las Clases son enfocadas en valores y comportamientos, pueden contener muchos metodos y propiedades 
    Cada instancia aparta un bloque de memoria con un identificador y aun que hacen referencia a las mismas propiedades, estas son totalmente diferentes
     */
    public class Tipos_Registro_y_Escritura
    {
        //TIPOS DE REGISTROS Y ESCRITURA
        public void main()
        {
            var jarra1 = new Jarra() { Id = 1, TieneBebida = true, Sabor = "Limonada" };
            var jarra2 = new Jarra() { Id = 1, TieneBebida = true, Sabor = "Limonada" };

            /*
             * Podemos hacer una comparativa de ambas instancias, a pesar de que son las mismas propiedades, 
             * al declarar los objectos, se crea un espacio unico para cada instancia, 
             * por lo que el resultado de la comparación es falsa
             */
            Console.WriteLine(jarra1 == jarra2);

            JarraRecord jarraR1 = new JarraRecord(1, true, "Naranjada");
            JarraRecord jarraR2 = new JarraRecord(1, true, "Naranjada");

            Console.WriteLine(jarraR1 == jarraR2);
        }


    }


    public class Jarra
    {
        public int Id;
        public bool TieneBebida;
        public string Sabor;

    } 

    public record  JarraRecord(int Id,bool TieneBebida, string Sabor);
}
