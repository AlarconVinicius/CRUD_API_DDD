using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Entidades.Entidades
{
    public class Categoria : Entity
    {
        public string Nome { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
