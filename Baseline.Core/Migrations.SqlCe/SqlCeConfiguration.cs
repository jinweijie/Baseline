namespace Baseline.Core.Migrations.SqlCe
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class SqlCeConfiguration : DbMigrationsConfiguration<EFContext>
    {
        public SqlCeConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFContext context)
        {
            DatabaseInitializer.SeedContext(context);
        }
    }
}
