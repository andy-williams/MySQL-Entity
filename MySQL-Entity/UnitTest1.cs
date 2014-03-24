using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySQL_Entity.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var libraryContext = new LibraryContext())
            {
                var author = new Author() { Forenames = "Robert C.", Surname = "Martin" };
                var book = new Book() { Author = author, Title = "Clean Code" };

                libraryContext.Authors.Add(author);
                libraryContext.Books.Add(book);
                libraryContext.SaveChanges();

                var bookResult = (from b in libraryContext.Books
                                  where book.Author.Surname == "Martin"
                                  select b).First<Book>();

                Assert.AreEqual("Clean Code", bookResult.Title);

                libraryContext.Books.Remove(book);
                libraryContext.Authors.Remove(author);

                libraryContext.SaveChanges();

                var bookCount = (from b in libraryContext.Books
                                 select b).Count<Book>();

                Assert.AreEqual(0, bookCount);
            }
            
        }
    }
}
