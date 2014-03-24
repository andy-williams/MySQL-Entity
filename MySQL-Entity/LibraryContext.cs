using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_Entity
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }

    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        public virtual Author Author { get; set; }
    }

    public class Author
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(128)]
        public string Forenames { get; set; }
        [MaxLength(128)]
        public string Surname { get; set; }
    }
}
