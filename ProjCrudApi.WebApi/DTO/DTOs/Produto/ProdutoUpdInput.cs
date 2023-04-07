using ProjCrudApi.Entidades.Enums;

namespace ProjCrudApi.WebApi.DTO.DTOs.Produto
{
    public class ProdutoUpdInput
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Guid CategoriaId { get; set; }
        public Status Status { get; set; }
    }
}
