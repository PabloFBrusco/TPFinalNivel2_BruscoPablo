using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ayudas
{
    public class Validaciones
    {
        public bool validarNumeros(string cadena)
        {
            try
            {
                float.Parse(cadena);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool validarComboRequerido(string combo)
        {
            bool requerido = false;
            if (combo == "-1")
            {
                requerido = true;
            }
            return requerido;
        }
        public bool validarTextoRequerido(string texto)
        {
            bool requerido = false;
            if (texto == "")
            {
                requerido = true;
            }
            return requerido;
        }
        public bool validarFiltro(string combo, bool campo, string filtro)
        {
            bool resultado = false;

            if (campo)
            {
                if (combo == "-1")
                {
                    resultado = true;
                }
                else if (filtro == "")
                {
                    resultado = true;
                }
            }
            return resultado;
        }

    }

}
