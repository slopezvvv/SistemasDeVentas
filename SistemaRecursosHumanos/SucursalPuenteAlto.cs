using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRecursosHumanos
{
    class SucursalPuenteAlto : Sucursal
    {

        public SucursalPuenteAlto(int id) : base(id)
        {
            _comision = 0.03;
        }

        public override bool ContratarPersonal(Empleado empleado)
        {
            if (empleado == null)
                return false;

            if (empleado.Nombre == string.Empty)
                return false;

            if (empleado.Edad < 17)
                return false;

            empleado.Salario = empleado.Salario * (1 - _comision);

            return true;
        }
    }
}
