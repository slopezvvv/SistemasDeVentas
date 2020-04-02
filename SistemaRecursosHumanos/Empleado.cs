using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class Empleado : Persona
    {
        private double _salario;
        public Empleado(int rut, int edad, string nombre, double salario) : base(rut, edad, nombre)
        {
            _salario = salario;
        }
        public double Salario { get => _salario; set => _salario = value; }
    }
}
