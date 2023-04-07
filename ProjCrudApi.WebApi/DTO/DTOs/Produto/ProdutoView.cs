using ProjCrudApi.Entidades.Enums;

namespace ProjCrudApi.WebApi.DTO.DTOs.Produto
{
    public class ProdutoView
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Guid CategoriaId { get; set; }
        public string Status { get { return StatusNum.ToString(); } set { StatusNum = Enum.Parse<Status>(value); } }
        public Status StatusNum { get; set; }
        public string? DataAlteracao { get; set; }
        public string? DataCriacao { get; set; }
    }
}
