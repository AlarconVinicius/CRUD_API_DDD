using ProjCrudApi.Entidades.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjCrudApi.WebApi.DTO.DTOs.Produto
{
    public class ProdutoAddInput
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
