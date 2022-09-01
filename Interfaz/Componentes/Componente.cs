using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Interfaz.Componentes
{
    internal abstract class Componente
    {
        public void implementar()
        {
            Console.WriteLine("Instalar antes de accesorios");
        }
        public abstract void RPM();
    }
}
