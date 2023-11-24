using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    //define los metodos para interactuar con chat 
    //Esta carpeta de repositorios nos dice que lo que podemos hacer sobre las entidades, alta baja, modificacion, obtener por id por ejemplo
    public interface IChatRepository:IUnitOfWork<Chat>
    {
        Task Preguntar { get; set; }
        Task Responder { get; set; }

    }
}
