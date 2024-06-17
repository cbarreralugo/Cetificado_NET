using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /*
     Busca crear conceptos mas genericos, como si se tratara de una plantilla
    Para implementar la abstracción, la clase y método deben ser abstractos
     */
    public class Abstraccion : Metodos_Personalizados
    {
        public void main()
        {
            var consultar = new Notificacion();
            ImprimirMensaje(consultar.FechaServer());
        }
    }

    public abstract class Utilidades
    {
        public abstract string FechaServer();
    }

    class Notificacion : Utilidades
    {

        public override string FechaServer()
        {
            var Fecha = DateTime.Now.ToString("G");
            return $"Ultima actualización al server fue {Fecha}";
        }
    }
}
