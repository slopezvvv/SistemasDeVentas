using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class Empleado
    {
        private readonly int _rut;
        private int _edad;
        private string _nombre;
        private double _salario;

        public Empleado(int rut, int edad, string nombre, double salario)
        {
            _rut = rut;
            _edad = edad;
            _nombre = nombre;
            _salario = salario;
        }

        // Accesador y mutador en C#
        public int Rut => _rut;
        public int Edad { get => _edad; set => _edad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Salario { get => _salario; set => _salario = value; }
    }
}
