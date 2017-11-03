using System.Collections.Generic;

namespace CoreProvider.Repository.Interface
{
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Obtienen una lista de elementos del repositorio
        /// </summary>
        IEnumerable<T> List { get; }

        /// <summary>
        /// Agrega un elemento al repositorio
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Elimina elemento del repositorio
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Actualiza un elemento
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Busca un elemento por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T FindById(int id);
    }
}
