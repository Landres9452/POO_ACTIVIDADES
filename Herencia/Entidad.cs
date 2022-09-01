using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Herencia
{

    internal class Entidad
    {
        public string Name { get; protected set; }

        public Entidad(string Name)
        {
            this.Name = Name;
        }
    }
}
