
using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModeloDDD.infra.Context
{
    public class ProjetoModelocontext : DbContext 
        
    {
        public ProjetoModelocontext()
            : base("ProjetoModeloDDD")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }


    }
}
