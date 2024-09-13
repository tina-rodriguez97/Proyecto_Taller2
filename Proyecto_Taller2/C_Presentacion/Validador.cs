using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taller2.C_Presentacion
{
    public class Validador
    {
        public Validador() 
        {  
        }

        public bool validarCampo(ErrorProvider ep,TextBox tb,int logitud_min = 0)
        {
            ep.Clear();
            if (string.IsNullOrEmpty(tb.Text))
            {
                ep.SetError(tb, "Este campo es requerido");
                return false;
            }

            if (tb.TextLength < logitud_min)
            {
                ep.SetError(tb, $"Este campo debe tener al menos {logitud_min} caracteres.");
                return false;
            } 

            return true;
        }
    }
}
