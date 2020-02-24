using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class GuardadorCXPHistorial : GuardadorCXP
    {
        public override void Guardar(int id, decimal importe, string naturaleza)
        {
            base.Guardar(id, importe, naturaleza);
            base.GuardaHistorial();
        }

    }
}
