using ProjCrudApi.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Entidades.Entidades
{
    public class Produto : Entity
    {
        public string  Nome { get; set; }
        public double Valor { get; set; }
        [ForeignKey("Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
        public Status Status { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
