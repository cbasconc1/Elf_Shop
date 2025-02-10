using System;
using System.Collections.Generic;

namespace Datos
{
    public partial class Cliente
    {
        public Cliente()
        {
            Productos = new HashSet<Producto>();
        }

        public long Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; }
        public string Correo { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public bool? Active { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
