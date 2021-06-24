using System;
using efcore.ValueObjects;

namespace efcore.Domain
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }
        public bool Ativo { get; set; }
    }
}