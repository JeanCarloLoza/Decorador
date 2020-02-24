using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    interface IGuardadorCXP
    {
        public void Guardar(int id, decimal importe, string naturaleza);
    }
}
