using ProjCrudApi.Dominio.Interfaces.IClasses;
using ProjCrudApi.Dominio.Interfaces.IServicos;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Dominio.Servicos
{
    public class ServicoCategoria : IServicoCategoria
    {
        private readonly ICategoria _iCategoria;
        public ServicoCategoria(ICategoria iCategoria)
        {
            _iCategoria = iCategoria;
        }
        public async Task AdicionarCategoria(Categoria objeto)
        {
            objeto.DataAlteracao = DateTime.Now;
            objeto.DataCriacao = DateTime.Now;
            await _iCategoria.Add(objeto);
        }

        public async Task AtualizarCategoria(Categoria objeto)
        {
            //var objetoId = await _iCategoria.GetEntityById(objeto.Id); 
            objeto.DataAlteracao = DateTime.Now;
            //objeto.DataAlteracao = objetoId.DataCriacao;
            await _iCategoria.Update(objeto);
        }

        public async Task DeletarCategoria(Categoria objeto)
        {
            await _iCategoria.Delete(objeto);
        }

        public async Task<List<Categoria>> ListarCategorias()
        {
            return await _iCategoria.List();
        }
    }
}
