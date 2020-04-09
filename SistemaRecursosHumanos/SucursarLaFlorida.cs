using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class SucursarLaFlorida : Sucursal
    {
        public SucursarLaFlorida(int id) : base(id)
        {
            _comision = 0.04;
        }

        public override bool ContratarPersonal(Empleado empleado)
        {
            if (empleado == null)
                return false;

            if (empleado.Nombre == string.Empty)
                return false;

            empleado.Salario = empleado.Salario * (1 - _comision);

            return true;
        }
    }
}
