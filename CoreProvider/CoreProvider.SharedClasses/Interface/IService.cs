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

        /// <summary>
        /// Lista de politicas de cancelacion
        /// </summary>
        IList<CancellationPolicy> CancellationPolicies { get; set; }
    }

    public class CancellationPolicy
    {
        /// <summary>
        /// Fecha en que entra en vigencia la politica
        /// </summary>
        public DateTime BeginPolicy { get; set; }

        /// <summary>
        /// Descripcion de la politica
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Precio a pagar por entrar en politicas de cancelacion
        /// </summary>
        public double Price { get; set; }
    }
}
