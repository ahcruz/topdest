namespace CoreProvider.SharedClasses
{
    public class Mapping
    {
        /// <summary>
        /// Pais a buscar en el proveedor
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Ciudad a buscar en el proveedor
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Codigos o ids a buscar en el proveedor
        /// </summary>
        public string[] Ids { get; set; }
    }
}