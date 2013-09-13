using Baseline.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseline.Core
{
    public class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public static Func<EFContext> FactoryMethod { get; set; }

        public EFContext()
            : base("name=BaselineDB")
        { }

        public EFContext(DbConnection conn) : base(conn, true)
        {
        }

        public EFContext(IDatabaseInitializer<EFContext> initializer)
        {
            Database.SetInitializer(initializer);
        }

        public static EFContext Get()
        {
            if (FactoryMethod != null) return FactoryMethod();

            return new EFContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
