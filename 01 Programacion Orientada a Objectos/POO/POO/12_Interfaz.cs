using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    /*
    Son Contratos que garantizan una estructura dentro de la clase, y asi poder usar la clase en diferentes partes del proyecto
    Permite elementos abstractos por default
    Permite realizar multiples abstracciones, por lo que podemos exterder baste el codigo.

    Las interfaces estan bastantemente ligada a SOLID
    SOLICD: 
        Es un grupo de principios que obligan a tener buenas practicas de programación

    Algunas de las caracteristicas es que se nombran con una I al principio
    Garantiza escalabilidad, por lo que es muy utilizado en patrones de diseño
    Podemos implementar generics
    */
    public class Interfaz : IConsulta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void main()
        {
            var imp = new Utilidad();
            Id = 1;
            Nombre = "Carlos";
            Edad = 21;

            imp.Imprimir(this);
        }
    }

    public class Utilidad : Metodos_Personalizados
    {
        public void Imprimir(IConsulta consulta)
        {
            ImprimirMensaje($"Id: {consulta.Id}");
            ImprimirMensaje($"Nombre: {consulta.Nombre}");
            ImprimirMensaje($"Edad: {consulta.Edad}");
        }
    }

    public interface IConsulta
    {
        int Id { get; set; }
        string Nombre { get; set; }
        int Edad { get; set; }

    }
}
