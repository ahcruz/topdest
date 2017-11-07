using System.Collections.Generic;
using CoreProvider.Domain.Interface;
using Geo;

namespace CoreProvider.Domain
{
    public class Hotel : IEntity
    {
        /// <inheritdoc />        
        public int Id { get; set; }

        /// <summary>
        /// Proveedor
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Nombre del hotel
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Direccion
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ciudad
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Pais
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Coordenadas
        /// </summary>
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// Detalles del hotel
        /// </summary>
        public HotelDetails Details { get; set; }

        /// <summary>
        /// Imagenes del hotel
        /// </summary>
        public IList<HotelImg> Images { get; set; }
    }

    public class HotelImg
    {
    }

    public class HotelDetails
    {
    }

    public class Country
    {
    }

    public class City
    {
    }
}
