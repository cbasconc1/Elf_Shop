using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Menu
    {
        public long Id { get; set; }
        public string? Text { get; set; }
        public string? Destino { get; set; }
        public bool? Activo { get; set; }

        public List<Menu> GetActiveMenus() 
        {
            var list = new List<Menu>();

            var NegocioMenus = new List<Menu>();

            using (var menudb = new Datos.ModelContext())
            {
                var listado = menudb.Menus.Where(menus => menus.Activo == true);

                foreach (var m in listado)
                {
                    NegocioMenus.Add(new Menu()
                    {
                        Destino = m.Destino,
                        Text = m.Text,
                        Id = m.Id,
                    });
                }
            }
            return list;
        }
        public List<Menu> GetInactiveMenus()
        {
            var list = new List<Menu>();

            var NegocioMenus = new List<Menu>();

            using (var menudb = new Datos.ModelContext())
            {
                var listado = menudb.Menus.Where(menus => menus.Activo == false);

                foreach (var m in listado)
                {
                    NegocioMenus.Add(new Menu()
                    {
                        Destino = m.Destino,
                        Text = m.Text,
                        Id = m.Id,
                    });
                }
            }
            return list;
        }
    }
}
