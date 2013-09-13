namespace Baseline.Core.Migrations.SqlServer
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class SqlServerConfiguration : DbMigrationsConfiguration<EFContext>
    {
        public SqlServerConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFContext context)
        {
            DatabaseInitializer.SeedContext(context);
        }
    }
}
