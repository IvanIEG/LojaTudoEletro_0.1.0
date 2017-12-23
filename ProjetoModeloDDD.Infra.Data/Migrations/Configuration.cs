using System.Data.Entity.Migrations;
using Ivan.LojaTudoEletro.Infra.Data.Contexto;

namespace Ivan.LojaTudoEletro.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoTudoEletroContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoTudoEletroContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
