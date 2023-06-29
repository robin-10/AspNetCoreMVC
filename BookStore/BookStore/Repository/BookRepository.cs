using System.Collections.Generic;
using System.Linq;
using BookStore.Models;

namespace BookStore.Repository {
  public class BookRepository {

    public List<BookModel> GetAllBooks() {
      return DataSource();
    }

    public BookModel GetABookById( int id ) {
      return DataSource().Where( a => a.Id == id ).FirstOrDefault();  
    }

    public List<BookModel> SearchBooks( string bookName, string authorName ) {
      return DataSource().Where( a => a.Title.Contains(bookName) || a.Author.Contains(authorName) ).ToList(); ;
    }

    private List<BookModel> DataSource() {
      return new List<BookModel>() {
        new BookModel() {Id=1, Title="MVC", Author="Robin" },
        new BookModel() {Id=2, Title="Java", Author="Johit" },
        new BookModel() {Id=3, Title="C++", Author="Cyan" },
        new BookModel() {Id=4, Title="PHP", Author="Jons" },
        new BookModel() {Id=5, Title="MVC", Author="Robin" }
      };
  }
  }
}
