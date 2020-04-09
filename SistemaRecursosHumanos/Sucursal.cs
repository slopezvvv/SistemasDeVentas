using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    abstract class Sucursal
    {
        // Atributos
        private readonly int _id;
        private string _nombre;
        private string _direccion;
        protected double _comision;
       
        // Constructores
        Sucursal()
        {
            _nombre = string.Empty;
            _direccion = string.Empty;
        }

        protected Sucursal(int id) : this()
        {
            _id = id;
        }

        // Metodos

        public abstract bool ContratarPersonal(Empleado empleado);

        // get y sets...
        public int Id => _id;
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
