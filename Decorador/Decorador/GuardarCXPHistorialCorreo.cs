using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class GuardadorCXPHistorialCorreo : GuardadorCXP
    {

        public override void Guardar(int id, decimal importe, string naturaleza)
        {
            base.Guardar(id, importe, naturaleza);
            base.GuardaHistorial();
            base.EnvarCorreo();
        }
    }
}
