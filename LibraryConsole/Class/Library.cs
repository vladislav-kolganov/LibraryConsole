using LibraryConsole.Enum;
using LibraryConsole.Interface;
using LibraryConsole.Resource;
using LibraryConsole.Result;

namespace LibraryConsole.Class
{
    /// <summary>
/// Класс библиотеки, хранящей коллекцию книг и методы для работы 
/// </summary>
    public class Library : ILibraryBook
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        /// <summary>
        /// Метод для добавления новой книги
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public BaseResult<Book> AddBook(Book book)
        {
            if (book == null)
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.BookIsEmpty,
                    ErrorMessage = ErrorMessage.BookIsEmpty
                };
            }
            if (Books.Any(x => x.Id == book.Id))
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.BookAlreadyExists,
                    ErrorMessage = ErrorMessage.BookAlreadyExists
                };

            }

            Books.Add(book);

            return new BaseResult<Book>()
            {
                Data = book
            };
        }


        /// <summary>
        /// Метод для получения книги по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult<Book> GetBookById(int id)
        {
            if (Books.Count == 0)
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.LibraryIsEmpty,
                    ErrorMessage = ErrorMessage.LibraryIsEmpty
                };

            }

            var book = Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.BookNotFound,
                    ErrorMessage = ErrorMessage.BookNotFound
                };
            }
            return new BaseResult<Book>()
            {
                Data = book
            };
        }

        /// <summary>
        /// Мето вывода информации о всех книгах
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void ListAllBooks()
        {
            if (Books.Count == 0)
            {
                Console.WriteLine(ErrorMessage.LibraryIsEmpty);
                return;

            }

            foreach (var book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }


        /// <summary>
        /// метод удаления книги по id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResult<Book> RemoveBook(int id)
        {
            if (Books.Count == 0)
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.LibraryIsEmpty,
                    ErrorMessage = ErrorMessage.LibraryIsEmpty
                };

            }

            var book = Books.FirstOrDefault(x => x.Id == id);


            if (book == null)
            {
                return new BaseResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.BookNotFound,
                    ErrorMessage = ErrorMessage.BookNotFound
                };
            }

            var res = Books.Remove(book);

            return new BaseResult<Book>()
            {
                Data = book
            };
        }


        /// <summary>
        /// Метод поиска книг по названию (частичное совпадение)
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public CollectionResult<Book> SearchBooks(string title)
        {
            if (Books.Count == 0)
            {
                return new CollectionResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.LibraryIsEmpty,
                    ErrorMessage = ErrorMessage.LibraryIsEmpty
                };
            }

            var books = Books.Where(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();

            if (books.Count == 0)
            {
                return new CollectionResult<Book>()
                {
                    ErrorCode = (int)BookErrorCodes.BookNotFound,
                    ErrorMessage = ErrorMessage.BookNotFound
                };
            }

            return new CollectionResult<Book>()
            {
                Data = books
            };
        }
    }


}

