using Microsoft.EntityFrameworkCore;
using ProjCrudApi.Dominio.Interfaces.IClasses;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.Entidades.Enums;
using ProjCrudApi.Infraestrutura.Configuracao;
using ProjCrudApi.Infraestrutura.Repositorios.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Infraestrutura.Repositorios.Repositorios
{
    public class RepositorioProduto : RepositorioGenerico<Produto>, IProduto
    {
        public RepositorioProduto(ContextoBase context) : base(context)
        {
            
        }
        public async Task<List<Produto>> ListarProdutosAtivos(Expression<Func<Produto, bool>> predicate)
        {
            return await _context.Produtos.Where(a => a.Status == Status.Ativo).AsNoTracking().ToListAsync();
        }
    }
}
