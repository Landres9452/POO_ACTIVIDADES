using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Herencia
{
    internal class Animal : Entidad
    {
        public string LastName { get; private set; }
        public Animal(string Name, string lastName) : base(Name)
        {
            LastName = lastName;
        }
    }
}