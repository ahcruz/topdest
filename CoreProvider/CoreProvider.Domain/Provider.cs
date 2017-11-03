using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProvider.Domain
{
    public class Provider
    {
        /// <summary>
        /// Id de proveedor
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del proveedor
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Descripcion del proveedor
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Atributo que indica si el proveedor esta o no activo
        /// </summary>
        public bool IsActive { get; set; }
    }
}
