using LibraryConsole.Class;
using LibraryConsole.Enum;
using LibraryConsole.Interface;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    ///  Состояние для добавления книги
    /// </summary>
    public class AddBookState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            Console.Clear();
            Console.WriteLine("Добавление новой книги");

            try
            {
                Console.Write("Введите идентификатор: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Введите название: ");
                string title = Console.ReadLine();

                Console.Write("Введите автора: ");
                string author = Console.ReadLine();

                Console.Write("Введите год издания: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Выберите жанр (1-Фантастика, 2-Детектив, 3-Роман, 4-Научная литература): ");
                BookGenre genre = (BookGenre)int.Parse(Console.ReadLine());


                var result = menu.Library.AddBook(new Book(id, title, author, year, genre));
                if (result.IsSuccess)
                {
                    Console.WriteLine("Книга успешно добавлена.");
                }
                else
                {
                    Console.WriteLine($"Ошибка: {result.ErrorMessage}, {result.ErrorCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода данных: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }

}
