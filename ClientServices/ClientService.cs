using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio; // importante PARA PODER USAR LA INTERFACE


namespace ClientServices
{
    public class ClientService : Negocio.IServiceCliente
    {
        public List<Cliente> GetUser()
        {
            var list = new List<Cliente>();

            using (var db = new Datos.ModelContext())
            {
                var listado = db.Clientes.Include(x => x.Productos);

                foreach (var m in listado)
                {
                    list.Add(new Cliente()
                    {
                        Id = m.Id,
                        Nombre = m.Nombre,
                        Apellido = m.Apellido,
                        UserName = m.UserName,
                        Correo = m.Correo,
                        Contraseña = m.Contraseña,
                        Productos = m.Productos.Select(x => new Negocio.Producto
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Precio = x.Precio,
                        }).Where(x => x.Vendido == true).ToArray()
                    });
                }
            }
            return list;
        }
        public void RegUser(Negocio.Cliente NeuClient) 
        {
           
       
            using (var db = new Datos.ModelContext())
            {
                if (db.Clientes.Any(x => x.Correo == NeuClient.Correo
                || x.UserName == NeuClient.UserName) )
                    throw new ArgumentException("No se envió nigun correo");

                var NewNegocioCliente = new Datos.Cliente()
                {
  
                    Nombre = NeuClient.Nombre,
                    Apellido = NeuClient.Apellido,
                    Correo = NeuClient.Correo,
                    Contraseña = NeuClient.Contraseña,
                    UserName = NeuClient.UserName
                    
                };
                db.Add(NewNegocioCliente);
                db.SaveChanges();
            }
        }
        public void Ediar(Negocio.Cliente NeuClient)
        {
            using (var db = new Datos.ModelContext())
            {

                var dbclient = db.Clientes.Single(x=>x.Id == NeuClient.Id);

               
                dbclient.Nombre = NeuClient.Nombre;
                dbclient.UserName = NeuClient.UserName;
                dbclient.Apellido = NeuClient.Apellido;
                dbclient.Contraseña = NeuClient.Contraseña;
                db.Update(dbclient);

                db.SaveChanges();
            }
        }


    }
}
