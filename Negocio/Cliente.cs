using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {


        public long? Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; }
        public string Correo { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public bool? Active { get; set; }
        public Producto[]? Productos { get; set; }

    }
}
