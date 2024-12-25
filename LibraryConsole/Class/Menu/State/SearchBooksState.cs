using LibraryConsole.Interface;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние поиска книг по названию
    /// </summary>
    public class SearchBooksState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            Console.Clear();
            Console.WriteLine("Поиск книги по названию");

            try
            {
                Console.Write("Введите название: ");
                string title = Console.ReadLine();

                var result = menu.Library.SearchBooks(title);
                if (result.IsSuccess)
                {

                    foreach (var r in result.Data)
                    {
                        Console.WriteLine(r.ToString());
                    }

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
