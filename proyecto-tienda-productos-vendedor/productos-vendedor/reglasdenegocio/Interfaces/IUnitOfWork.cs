using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        Task GuardarCambios();
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
        //Task<T> ObtenerPorId(int id);  //me va a devolver una entidad
      
    }
}
/* 
 * funciones de la interfaz 
 * funcion 1: herencia, hay tareas que van a ser comunes en todos los repositorios, como el alta baja modificacion, obtener por id, entonces 
 * en la iunitofwork, puedo crear esos metodos para que cuando yo herede de la interfaz iunitofwork, esos metodos no los tenga que repetir
  
*/