using System;

namespace SistemaRecursosHumanos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleado empleado = new Empleado(13456748, 19, "Jacob", 300000000.0);
            Empleado empleadoDos = new Empleado(13456748, 118, "Juanito", 3000000.0*5);


            SucursalEstacionCentral sucursalEstacionCentral = new SucursalEstacionCentral(0);
            Console.WriteLine("El id de estacion central es: "+sucursalEstacionCentral.Id);

            sucursalEstacionCentral.ContratarPersonal(empleado);

            Console.WriteLine("El sueldo del empleado '"+empleado.Nombre+"' es: "+empleado.Salario);
        }
    }
}
