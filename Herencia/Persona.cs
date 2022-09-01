using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Herencia
{
    internal class Persona : Entidad
    {
        public string FirstName { get; private set; }
        public Persona(string Name, string firstName) : base(Name)
        {
            FirstName = firstName;
        }
    }
}
