using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class SucursalEstacionCentral : Sucursal
    {

        public SucursalEstacionCentral(int id) : base(id)
        {
            _comision = 0.02;
        }

        public override bool ContratarPersonal(Empleado empleado)
        {
            if (empleado == null)
                return false;

            if(empleado.Nombre == string.Empty)
                return false;

            if (empleado.Edad < 18)
                return false;

            empleado.Salario = empleado.Salario * (1 - _comision);

            return true;
        }
    }
}
