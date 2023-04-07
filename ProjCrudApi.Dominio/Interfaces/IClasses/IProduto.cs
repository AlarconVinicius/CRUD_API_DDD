using ProjCrudApi.Dominio.Interfaces.IGenerica;
using ProjCrudApi.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Interfaces.IClasses
{
    public interface IProduto : IGenerica<Produto>
    {
        Task<List<Produto>> ListarProdutosAtivos(Expression<Func<Produto, bool>> predicate);
    }
}
