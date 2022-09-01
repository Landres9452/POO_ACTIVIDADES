using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Interfaz.Componentes
{
    internal class Embrague : Componente
    {
        public override void RPM()
        {
            Console.WriteLine("Se debe hacer el cambio a las 1500 revoluciones");
        }
    }
}
