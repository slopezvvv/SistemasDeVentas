using System;

namespace SistemaRecursosHumanos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleado empleado = new Empleado(13456748, 19, string.Empty, 3000000.0);
            Empleado empleadoDos = new Empleado(13456748, 118, "Mañalish", 3000000.0*5);
            Console.WriteLine("Hello World!");
            Console.WriteLine(string.Format("Nombre : {0}\nEdad : {1}\nRut : {2}\nSalario : {3}",
                (empleado.Nombre == string.Empty ? "No tiene nombre" : empleado.Nombre), // NOMBRE 0
                empleado.Edad, // EDAD 1
                empleado.Rut, // RUT 2
                empleado.Salario // SALARIO 3
                )
            );
            Console.WriteLine(string.Format("Nombre : {0}\nEdad : {1}\nRut : {2}\nSalario : {3}",
                (empleadoDos.Nombre == string.Empty ? "No tiene nombre" : empleadoDos.Nombre), // NOMBRE 0
                empleadoDos.Edad, // EDAD 1
                empleadoDos.Rut, // RUT 2
                empleadoDos.Salario // SALARIO 3
                )
            );
        }
    }
}
