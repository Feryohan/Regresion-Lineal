using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosTemporales
{
    class DatosPropiedades
    {
        #region Variables
        public string rutaArchivo { get; set; }
        public string nombreDatos { get; set; }
        public double[] datosEjeX { get; set; }
        public double[] datosEjeY { get; set; }
        public double pendiente { get; set; }
        public double ordenada { get; set; }
        public double[] regresionLineal { get; set; }

        #endregion

        #region Constructor
        //Constructor
        public DatosPropiedades()
        {
            rutaArchivo = "";
        }
        #endregion
    }
}
