using LibraryConsole.Class;
using LibraryConsole.Result;

namespace LibraryConsole.Interface
{
    public interface ILibraryBook
    {
        List<Book> Books { get; set; }
        BaseResult<Book> AddBook(Book book);
        BaseResult<Book> RemoveBook(int id);
        BaseResult<Book> GetBookById(int id);
        CollectionResult<Book> SearchBooks(string title);
        void ListAllBooks();
    }
}
