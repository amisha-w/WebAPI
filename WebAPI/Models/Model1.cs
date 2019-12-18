namespace WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.lname)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Role)
                .IsUnicode(false);
        }
    }
}
