using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    /*
     Un contructor nos ayuda inicializar los valores de un objectos que son creados a base de una clase
     La idea es crear un metodo para colocar datos por deafaul a nuestros objectos, ayuda a que cada vez que inicialicemos un objecto, ya contenga un dato inicial
     El contructor no se define con un tipo de dato a retornar
     */
    public class Contructor_y_Datos_Iniciales
    {
        public int Matricula;
        public string Alumno;
        public int Curso;
        public List<Materia> Materias;

        public Contructor_y_Datos_Iniciales()
        {
            Matricula = 0;
            Alumno = string.Empty;
            Curso = 0;
            Materias = new List<Materia>(); 
        }

    }

    public class Materia
    {
        public int IdMateria = 0;
        public string NombreMateria = string.Empty; 
    }
}
