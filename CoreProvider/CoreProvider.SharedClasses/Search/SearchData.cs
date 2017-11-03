using System;
using System.Collections.Generic;

namespace CoreProvider.SharedClasses.Search
{
    /// <summary>
    /// Clase que contendria datos para poder realizar una busqueda
    /// </summary>
    public class SearchData
    {
        /// <summary>
        /// Ocupaciones
        /// </summary>
        public IList<Occupancy> Occupancies { get; set; }

        /// <summary>
        /// Ingreso al servicio
        /// </summary>
        public DateTime CheckIn { get; set; }

        /// <summary>
        /// Salida del servicio
        /// </summary>
        public DateTime CheckOut { get; set; }

        /// <summary>
        /// Mapeo de hoteles en base a su provveedor
        /// </summary>
        public Mapping Mapping { get; set; }
    }
}
