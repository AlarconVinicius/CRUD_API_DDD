using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Interfaces.IGenerica
{
    public interface IGenerica<T> where T : class
    {
        Task Add(T objeto);
        Task Update(T objeto);
        Task Delete(T objeto);
        Task<T> GetEntityById(Guid Id);
        Task<List<T>> List();
    }
}
