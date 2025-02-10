using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IServiceCliente
    {
        public List<Cliente> GetUser();
        public void RegUser(Negocio.Cliente NeuClient);
        public void Ediar(Negocio.Cliente NeuClient);
    }
}
