using ProjCrudApi.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Interfaces.IServicos
{
    public interface IServicoCategoria
    {
        Task AdicionarCategoria(Categoria objeto);
        Task AtualizarCategoria(Categoria objeto);
        Task DeletarCategoria(Categoria objeto);
        Task<List<Categoria>> ListarCategorias();
    }
}
