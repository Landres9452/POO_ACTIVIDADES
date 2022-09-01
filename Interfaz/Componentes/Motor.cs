using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Interfaz.Componentes
{
    internal class Motor : Componente
    {
        public override void RPM()
        {
            Console.WriteLine("El motor anda a 85mil revoluciones por minuto");
        }
    }
}
