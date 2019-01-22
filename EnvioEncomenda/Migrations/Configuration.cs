namespace EnvioEncomenda.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EnvioEncomenda.Models.EnvioEncomendaContext>
    {   
        // Classe responsavel pela migração automatica de banco de dados - Luis Novaes
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EnvioEncomenda.Models.EnvioEncomendaContext";
        }

        protected override void Seed(EnvioEncomenda.Models.EnvioEncomendaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
