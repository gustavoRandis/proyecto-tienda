﻿namespace Tiendita.ReglasdeNegocio.Interfaces.Getways.GetwaysProducto.ProductoInputPort
{
    /// <summary>
    /// Este Input Port se utiliza para recuperar información sobre un actor 
    /// específico en función de su Id.
    /// </summary>
    public interface IObtenerProductoInputPort
    {
        /// <summary>
        /// El método Handle recibiría el Id del actor y devolvería un objeto que 
        /// contiene los detalles del actor.
        /// </summary>
        /// <param name="idActor">Id del actor a buscar.</param>
        /// <returns>Detalles del actor.</returns>
        Task Handle(int idProducto);
    }

}
