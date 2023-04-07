using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjCrudApi.Dominio.Interfaces.IServicos;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.WebApi.DTO.DTOs.Categoria;
using System.Security.Principal;

namespace ProjCrudApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IServicoCategoria _iServicoCategoria;
        private readonly IMapper _mapper;

        public CategoriaController(IServicoCategoria iServicoCategoria, IMapper mapper)
        {
            _iServicoCategoria = iServicoCategoria;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task AddCategoria(CategoriaAddInput objeto)
        {
            var objetoMapeado = _mapper.Map<Categoria>(objeto);
            await _iServicoCategoria.AdicionarCategoria(objetoMapeado);
        }

        [HttpGet]
        public async Task<List<CategoriaView>> ListarCategorias()
        {
            var objeto = await _iServicoCategoria.ListarCategorias();
            var objetoMapeado = _mapper.Map<List<CategoriaView>>(objeto);
            return objetoMapeado;
        }

        [HttpPut]
        public async Task AtualizarCategoria(CategoriaUpdInput objeto)
        {
            var objetoMapeado = _mapper.Map<Categoria>(objeto);
            await _iServicoCategoria.AtualizarCategoria(objetoMapeado);
        }

        [HttpDelete]
        public async Task DeletarCategoria(CategoriaView objeto)
        {
            var objetoMapeado = _mapper.Map<Categoria>(objeto);
            await _iServicoCategoria.DeletarCategoria(objetoMapeado);
        }
    }
}
