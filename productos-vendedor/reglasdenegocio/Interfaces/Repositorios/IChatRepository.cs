using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    public interface IChatRepository:IUnitOfWork<Chat>
    {
        Task Preguntar { get; set; }
        Task Responder { get; set; }

    }
}
