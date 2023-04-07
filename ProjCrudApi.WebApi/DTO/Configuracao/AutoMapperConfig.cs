using AutoMapper;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.WebApi.DTO.DTOs.Categoria;
using ProjCrudApi.WebApi.DTO.DTOs.Produto;

namespace ProjCrudApi.WebApi.DTO.Configuracao
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CategoriaAddInput, Categoria>();
            CreateMap<CategoriaUpdInput, Categoria>();
            CreateMap<CategoriaView, Categoria>().ReverseMap()
                .ForMember(cvm => cvm.DataAlteracao, options => options.MapFrom(te => te.DataAlteracao.ToString("dd/MM/yyyy")))
                .ForMember(cvm => cvm.DataCriacao, options => options.MapFrom(te => te.DataCriacao.ToString("dd/MM/yyyy")));

            CreateMap<ProdutoAddInput, Produto>();
            CreateMap<ProdutoUpdInput, Produto>();
            CreateMap<ProdutoView, Produto>().ReverseMap()
                .ForMember(cvm => cvm.DataAlteracao, options => options.MapFrom(te => te.DataAlteracao.ToString("dd/MM/yyyy")))
                .ForMember(cvm => cvm.DataCriacao, options => options.MapFrom(te => te.DataCriacao.ToString("dd/MM/yyyy")));
        }
    }
}
