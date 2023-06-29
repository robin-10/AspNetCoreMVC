using System.Collections.Generic;
using System.Security.Policy;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers {
  public class BookController: Controller {

    private readonly BookRepository _bookRepository = null;
    public BookController() {
      _bookRepository = new BookRepository();
    }
    public ViewResult GetAllBooks() {
      var data = _bookRepository.GetAllBooks();
      return View();
    }

    public BookModel GetBook(int id) {
      return _bookRepository.GetABookById(id);
    }

    public List<BookModel> SearchBooks(string bookName, string authorName) {
      return _bookRepository.SearchBooks(bookName,authorName);
    }
  }
}
