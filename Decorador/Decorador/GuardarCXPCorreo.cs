using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class GuardadorCXPCorreo : GuardadorCXP
    {
        public override void Guardar(int id, decimal importe, string naturaleza)
        {
            base.Guardar(id, importe, naturaleza);
            base.EnvarCorreo();
        }

    }
}
