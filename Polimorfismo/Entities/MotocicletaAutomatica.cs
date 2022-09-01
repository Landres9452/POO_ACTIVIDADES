using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVIDADES.Entities
{
    internal class MotocicletaAutomatica:Entity
    {
        public string Transmision { get; protected set; }
        public MotocicletaAutomatica(string id, string placa, string transmision) : base(id, placa)
        {
            Transmision = transmision;
        }



    }
}
