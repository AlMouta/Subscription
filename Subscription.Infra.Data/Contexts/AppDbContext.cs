using Microsoft.EntityFrameworkCore;
using Subscription.Infra.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Subscription.Infra.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        //Método construtor para receber as opções de configuração do DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        //Sobrescrever o método para configurar os mapeamentos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new AssinaturaConfiguration());
            modelBuilder.ApplyConfiguration(new PlanoConfiguration());
        }
    }
}
