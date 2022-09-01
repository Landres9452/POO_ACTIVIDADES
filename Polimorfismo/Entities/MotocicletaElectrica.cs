using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Entities
{
    internal class MotocicletaElectrica:Entity
    {
        public string TipoBateria { get; protected set; }
        public MotocicletaElectrica(string id, string placa, string tipoBateria) : base(id, placa)
        {
            TipoBateria = tipoBateria;
        }

        public void Encendido() 
        { 
            Console.WriteLine("Encendiendo Motocicleta");
        }

    }
}
