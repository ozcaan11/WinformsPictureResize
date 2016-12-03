namespace FrmPicture.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class myDb : DbContext
    {
        public myDb()
            : base("name=myDb")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
