using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models.ENTIDADES
{
    public class clsPersona
    {
        #region Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion Atributos
        #region Constructor
        public clsPersona(string nombreUsu, string ApellidoUsu)
        {
            Nombre = nombreUsu;
            Apellido = ApellidoUsu;

        }
        #endregion

    }
}
