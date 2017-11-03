using System;
using System.Collections.Generic;

namespace CoreProvider.SharedClasses.Interface
{
    /// <summary>
    /// Interface de servicio
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Inicio del servicio
        /// </summary>
        DateTime BeginService { get; set; }

        /// <summary>
        /// Fin del servicio
        /// </summary>
        DateTime EndService { get; set; }

        /// <summary>
        /// Precio neto
        /// </summary>
        double NetPrice { get; }

        /// <summary>
        /// Datos extras necesarios para seguir el workflow del proveedor
        /// </summary>
        Dictionary<string, string> ProviderData { get; set; }

        /// <summary>
        /// Ocupacion
        /// </summary>
        Occupancy Occupancy { get; set; }
    }
}
