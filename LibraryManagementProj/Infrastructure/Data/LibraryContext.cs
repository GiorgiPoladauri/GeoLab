using LibraryManagementProj.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementProj.Infrastructure.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.BookID);

                entity.Property(b => b.BookName)
                      .IsRequired()
                      .HasMaxLength(30);

                entity.Property(b => b.Description)
                      .HasMaxLength(500);

                entity.Property(b => b.PublicationDate)
                      .IsRequired();

                entity.Property(b => b.AuthorName)
                      .IsRequired()
                      .HasMaxLength(30);

                entity.Property(b => b.Pages)
                      .IsRequired();

                entity.Property(b => b.Quantity)
                      .IsRequired();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.UserID);

                entity.Property(u => u.UserName)
                      .IsRequired()
                      .HasMaxLength(30);

                entity.Property(u => u.PersonalNumber)
                      .IsRequired();

                entity.Property(u => u.Email)
                      .IsRequired();
            });

            modelBuilder.Entity<BorrowedBook>(entity =>
            {
                entity.HasKey(bb => bb.BorrowedBookID);

                entity.HasOne<Book>()
                      .WithMany() 
                      .HasForeignKey(bb => bb.BookID)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(bb => bb.UserID)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.Property(bb => bb.BorrowDate)
                      .IsRequired();

                entity.Property(bb => bb.ReturnDate)
                      .IsRequired();
            });
        }
    }
}
