using System;
using System.Collections.Generic;
using efcore.ValueObjects;

namespace efcore.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public string Observacao { get; set; }
        public ICollection<PedidoItem> Items { get; set; }
    }
}