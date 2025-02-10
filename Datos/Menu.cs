using System;
using System.Collections.Generic;

namespace Datos
{
    public partial class Menu
    {
        public long Id { get; set; }
        public string? Text { get; set; }
        public string? Destino { get; set; }
        public bool? Activo { get; set; }
    }
}
