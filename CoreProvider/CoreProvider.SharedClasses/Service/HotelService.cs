using System;
using System.Collections.Generic;
using CoreProvider.SharedClasses.Interface;

namespace CoreProvider.SharedClasses.Service
{
    /// <inheritdoc />    
    public class HotelService : IService
    {
        /// <inheritdoc />
        public DateTime BeginService { get; set; }

        /// <inheritdoc />
        public DateTime EndService { get; set; }

        /// <inheritdoc />
        public double NetPrice { get; }

        /// <inheritdoc />
        public Dictionary<string, string> ProviderData { get; set; }

        /// <inheritdoc />
        public Occupancy Occupancy { get; set; }

        /// <summary>
        /// Precio del hotel
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Habitacion de hotel
        /// </summary>
        public Room Room { get; set; }

        /// <summary>
        /// Suplementos obtenidos del proveedor
        /// </summary>
        public IList<Supplement> Supplements { get; set; }

        /// <summary>
        /// Id del hotel en el proveedor
        /// </summary>
        public string ProviderId { get; set; }
    }

    public class Supplement
    {
        /// <summary>
        /// Tipo de suplemento
        /// </summary>
        public SupplementEnum Type { get; set; }

        /// <summary>
        /// Descripcion del suplemento
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Precio del suplemento
        /// </summary>
        public double Price { get; set; }
    }

    public enum SupplementEnum
    {
        Included,
        NotIncluded
    }
}
