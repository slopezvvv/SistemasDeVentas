using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class Persona
    {
        private readonly int _rut;
        private int _edad;
        private string _nombre;

        public Persona(int rut, int edad, string nombre)
        {
            _rut = rut;
            _edad = edad;
            _nombre = nombre;
        }

        public int Rut => _rut;
        public int Edad { get => _edad; set => _edad = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
