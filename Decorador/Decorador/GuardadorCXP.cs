using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    public abstract class GuardadorCXP : IGuardadorCXP
    {
        public virtual void Guardar(int id, decimal importe, string naturaleza)
        {
            Console.WriteLine("Guardando CXP con id: {0} importe: {1} naturaleza: {2}",id,importe,naturaleza);
        }
        public void EnvarCorreo()
        {
            Console.WriteLine("Enviando Correo ");
        }
        public void GuardaHistorial()
        {
            Console.WriteLine("Guardando Historial ");
        }
    }
}
