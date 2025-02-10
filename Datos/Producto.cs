using System;
using System.Collections.Generic;

namespace Datos
{
    public partial class Producto
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = null!;
        public bool? Vendido { get; set; }
        public long? Precio { get; set; }
        public string? Categoria { get; set; }
        public decimal? TemperaturaMedida { get; set; }
        public decimal? VoltajeMedido { get; set; }
        public decimal? CorrienteMedida { get; set; }
        public long? ClientId { get; set; }
        public string? Marca { get; set; }
        public long? Potencia { get; set; }

        public virtual Cliente? Client { get; set; }
    }
}
