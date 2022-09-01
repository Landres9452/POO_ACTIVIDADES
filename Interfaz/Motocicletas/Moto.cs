using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACTIVIDADES.Interfaz.Accesorios;
using ACTIVIDADES.Interfaz.Componentes;

namespace ACTIVIDADES.Interfaz.Motocicletas
{
    internal class Moto
    {
        private Accesorio Accesorio;
        private Accesorio Accesorio2;
        private Componente Motor;
        private Componente Embrague;

        public Moto(Accesorio accesorio, Accesorio accesorio2)
        {
            Accesorio = Accesorio;
            this.Motor=new Motor();
            this.Embrague=new Embrague();
            Accesorio2 = accesorio2;
            
           
        }
    }
}
