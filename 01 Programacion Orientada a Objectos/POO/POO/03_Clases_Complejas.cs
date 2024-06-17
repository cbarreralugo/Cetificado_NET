using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO
{
    public class Clases_Complejas
    {
        //CLASES COMPLEJAS
        public void main()
        {
            var poderVolar = new SuperPoder();
            poderVolar.Nombre = "Volar";
            poderVolar.Descripcion = "Capacidar de planear y volar en el aire";
            poderVolar.Nivel = NivelPoder.NivelUno;

            var poderFuerza = new SuperPoder();
            poderFuerza.Nombre = "Super fuerza";
            poderFuerza.Descripcion = "Fuerza suficiente para levantar el mundo.";
            poderFuerza.Nivel = NivelPoder.NivelTres;




            List<SuperPoder> listPoderSuperMan = new List<SuperPoder>();
            listPoderSuperMan.Add(poderVolar);
            listPoderSuperMan.Add(poderFuerza);

            var superman = new SuperHeroe();
            superman.Id = 1;
            superman.Nombre = "Superman";
            superman.IdentidadSecreta = "Clark Kent";
            superman.Ciudad = "Metropolis";
            superman.PuedeVolar = true;
            superman.SuperPoderes = listPoderSuperMan;
        }
    }

    public class SuperHeroe //Clases siempre se pronuncian en singular, se recomienda usar CamelCase
    {
        public Guid Id_unico; // Guid Se utiliza como identificador unico, se componen de números y letras
        public int Id;
        public string Nombre;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;//Esta lista se conoce como el tipo generic, es una lista que recive cualquier tipo privado de C# o personalizado
        public bool PuedeVolar;
    }

    public class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;


    }
    //Las enumeraciones en C#, nos permiten asignar valores especificos, limitando los valores a usar
    public enum NivelPoder
    {
        NivelUno = 1,
        NivelDos = 2,
        NivelTres = 3
    }
}
