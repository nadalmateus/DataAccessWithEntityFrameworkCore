using System;

namespace efcore.Domain
{
    public class PedidoItem
    {
        public Guid Id { get; set; }
        public Guid PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }

    }
}