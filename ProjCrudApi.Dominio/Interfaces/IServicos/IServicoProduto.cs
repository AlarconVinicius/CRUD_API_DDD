using ProjCrudApi.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Interfaces.IServicos
{
    public interface IServicoProduto
    {
        Task AdicionarProduto(Produto objeto);
        Task AtualizarProduto(Produto objeto);
        Task<List<Produto>> ListarProdutosAtivos();
    }
}
