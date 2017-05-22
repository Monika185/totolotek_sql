using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace bazy_ostateczne.Models
{
    public class BazyDbContext : DbContext
    {
        public BazyDbContext()
            : base("name=ProjektTotolotekMonikaString")
        {
            base.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<BazyDbContext>(null);
        }
        

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<BinaryCoupon> BinaryCoupon { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<BinaryResult> BinaryResult { get; set; }
        public virtual DbSet<Betting> Betting { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<BinaryCoupon>().ToTable("BinaryCoupon");
            modelBuilder.Entity<Result>().ToTable("Result");
            modelBuilder.Entity<BinaryResult>().ToTable("BinaryResult");
            modelBuilder.Entity<Betting>().ToTable("Betting");
        }
    }
}