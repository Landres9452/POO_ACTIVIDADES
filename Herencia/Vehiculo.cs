using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Herencia
{
    internal class Vehiculo : Entidad
    {

        public Vehiculo(string Name) : base(Name)
        {
        }
        public void Encendido()
        {
            Console.WriteLine("está encendido y listo para rodar");
        }
    }
}
