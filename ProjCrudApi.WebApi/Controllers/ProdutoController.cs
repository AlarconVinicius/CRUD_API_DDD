using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjCrudApi.Dominio.Interfaces.IServicos;
using ProjCrudApi.Dominio.Servicos;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.WebApi.DTO.DTOs.Produto;

namespace ProjCrudApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IServicoProduto _iServicoProduto;
        private readonly IMapper _mapper;

        public ProdutoController(IServicoProduto iServicoProduto, IMapper mapper)
        {
            _iServicoProduto = iServicoProduto;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task AddProduto(ProdutoAddInput objeto)
        {
            var objetoMapeado = _mapper.Map<Produto>(objeto);
            await _iServicoProduto.AdicionarProduto(objetoMapeado);
        }

        [HttpGet]
        public async Task<List<ProdutoView>> ListarProdutosAtivos()
        {
            var objeto = await _iServicoProduto.ListarProdutosAtivos();
            var objetoMapeado = _mapper.Map<List<ProdutoView>>(objeto);
            return objetoMapeado;
        }

        [HttpPut]
        public async Task AtualizarProduto(ProdutoUpdInput objeto)
        {
            var objetoMapeado = _mapper.Map<Produto>(objeto);
            await _iServicoProduto.AtualizarProduto(objetoMapeado);
        }
    }
}
