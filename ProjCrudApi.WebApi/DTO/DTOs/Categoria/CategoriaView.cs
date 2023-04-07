namespace ProjCrudApi.WebApi.DTO.DTOs.Categoria
{
    public class CategoriaView
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string? DataAlteracao { get; set; }
        public string? DataCriacao { get; set; }
    }
}
