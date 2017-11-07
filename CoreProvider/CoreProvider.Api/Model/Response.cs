using System;

namespace CoreProvider.Api.Model
{
    public class Response
    {
        /// <summary>
        /// Objeto respuesta
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// Tiempo en que se ejecutor el servicio
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Estado de la respuesta
        /// </summary>
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Mensaje en case de haber error
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}