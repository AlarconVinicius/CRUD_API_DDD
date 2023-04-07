using ProjCrudApi.Dominio.Interfaces.IClasses;
using ProjCrudApi.Dominio.Interfaces.IServicos;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Servicos
{
    public class ServicoProduto : IServicoProduto
    {
        private readonly IProduto _iProduto;

        public ServicoProduto(IProduto iProduto)
        {
            _iProduto = iProduto;
        }
        public async Task AdicionarProduto(Produto objeto)
        {
            objeto.DataAlteracao = DateTime.Now;
            objeto.DataCriacao = DateTime.Now;
            objeto.Status = Status.Ativo;
            await _iProduto.Add(objeto);

        }

        public async Task AtualizarProduto(Produto objeto)
        {
            objeto.DataAlteracao = DateTime.Now;
            await _iProduto.Update(objeto);
        }

        public async Task<List<Produto>> ListarProdutosAtivos()
        {
            return await _iProduto.ListarProdutosAtivos(p => p.Status == Status.Ativo);
        }
    }
}
