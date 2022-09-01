using ACTIVIDADES.Entities;
using ACTIVIDADES.Herencia;
using ACTIVIDADES.Interfaz;
using ACTIVIDADES.Interfaz.Accesorios;
using ACTIVIDADES.Interfaz.Motocicletas;
using ACTIVIDADES.Ejercicio_4_Factoria.Entidades;
using ACTIVIDADES.Ejercicio_4_Factoria.Factory;
/*
ACTIVIDAD 1 HERENCIA
*/
Persona p = new Persona("Juan","Ramirez");
Animal a = new Animal("Gato","Miaw");
Vehiculo c = new Vehiculo("Carro");
c.Encendido();
Console.WriteLine(p.Name + " " + p.FirstName + " " + " Tiene un " + " " + c.Name + " " + "y un " + a.Name+a.LastName);
/*
 CIERRE DE ACTIVIDAD 1
 */

/*
 ACTIVIDAD 2 POLIMORFISMO
 */
Entity motoc = new Motocicleta("1","byd123dc");
Entity motoa = new MotocicletaAutomatica("2","xds456tf","AUTOMÁTICA");
Entity motoe = new MotocicletaElectrica("3","trf789mn","LITIO");
var me1 = (MotocicletaElectrica)motoe;
me1.Encendido();
/*
 CIERRE DE ACTIVIDAD 2
 */

/*
 ACTIVIDAD 3 INTERFAZ
 */
Accesorio Accesorio = new Baul();
Accesorio Accesorio1 = new Espejos();

Moto moto = new Moto(Accesorio, Accesorio1);

/*
 CIERRE DE ACTIVIDAD 3
 */

/*
 ACTIVIDAD 4 FACTORY
 */
var concesionario = (Concesionario)Factory.CrearConcesionario();
concesionario.ubicacion= "Autonorte calle 18";
var propietario = (Propietario)Factory.CrearPropietario();
propietario.Nombre = "Andrés López";
var empleado = (Empleado)Factory.CrearEmpleado();
empleado.Nombre = "Carolina Gaitán";
empleado.cargo = "Vendedora de vitrina";


/*
 CIERRE DE ACTIVIDAD 4
 */