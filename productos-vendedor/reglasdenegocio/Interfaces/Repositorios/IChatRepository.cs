using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.Entity.Interfaces.Repositorios
{
    internal interface IChatRepository
    {
        Task Preguntar { get; set; }
        Task Responder { get; set; }

    }
}
