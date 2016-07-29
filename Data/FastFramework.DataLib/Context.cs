using FastFramework.DataLib.Models;
using System.Data.Entity;

namespace FastFramework.DataLib
{
    public partial class Context : DbContext
    {
        public Context()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(c => c.ToTable("T_" + c.ClrType.Name));
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> User { get; set; }
    }
}
