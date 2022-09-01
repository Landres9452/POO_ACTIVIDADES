using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACTIVIDADES.Ejercicio_4_Factoria.Entidades;

namespace ACTIVIDADES.Ejercicio_4_Factoria.Factory
{
    public static class Factory
    {
        public static Entidad CrearConcesionario()
        {
            return new Concesionario();
        }
        public static Entidad CrearPropietario()
        {
            return new Propietario();
        }
        public static Entidad CrearEmpleado()
        {
            return new Empleado();
        }
    }
}
