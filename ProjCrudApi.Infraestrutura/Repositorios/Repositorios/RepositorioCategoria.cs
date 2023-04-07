using ProjCrudApi.Dominio.Interfaces.IClasses;
using ProjCrudApi.Entidades.Entidades;
using ProjCrudApi.Infraestrutura.Configuracao;
using ProjCrudApi.Infraestrutura.Repositorios.Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Infraestrutura.Repositorios.Repositorios
{
    public class RepositorioCategoria : RepositorioGenerico<Categoria>, ICategoria
    {
        public RepositorioCategoria(ContextoBase context) : base(context)
        {
        }
    }
}
