using sistemasd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sistemasd
{
    public class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Categoria Categoria { get; set; }
        public int? CategoriaId { get; set; }
    }
}