using Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
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

        public List<Producto> GetStockProducts()
        {
            var list = new List<Producto>();

            using (var db = new Datos.ModelContext())
            {
                var listado = db.Productos.Where(p => p.Vendido == false || p.Vendido == null);

                foreach (var m in listado)
                {
                    list.Add(new Producto()
                    {
                        Id = m.Id,
                        Precio = m.Precio,
                        Categoria = m.Categoria,
                        Marca = m.Marca,
                        Potencia = m.Potencia,
                        Nombre = m.Nombre,
                        ClientId = m.ClientId
                        
                    });

                }

            }


            return list;
        }

        public List<Producto> GetSoldProducts()
        {
            var list = new List<Producto>();

            using (var db = new Datos.ModelContext())
            {
                var listado = db.Productos.Where(p => p.Vendido == true)
                    .ToArray();

                foreach (var m in listado)
                {
                    list.Add(new Producto()
                    {
                        Id = m.Id,
                        TemperaturaMedida = m.CorrienteMedida,
                        Precio = m.Precio,
                        Categoria = m.Categoria,
                        CorrienteMedida = m.CorrienteMedida,
                        VoltajeMedido = m.VoltajeMedido,
                        ClientId = m.ClientId,
                        Marca = m.Marca,
                        Nombre = m.Nombre,
                        Potencia=m.Potencia                       
                    }
        
                    );
                }
            }
            return list;
        }

      
    }
}

