using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SateliteException : Exception
    {
        #region Constructors

        /// <summary>
        /// Constructor sin parámetros
        /// Esta excepción se debe lanzar cuando se intenta crear un satélite que ya se encuentra en la lista.
        /// </summary>
        public SateliteException() : base("No se puede crear el satélite")
        {

        }

        #endregion
    }
}
