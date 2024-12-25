using LibraryConsole.Class.Menu.State;
using LibraryConsole.Interface;

namespace LibraryConsole.Class.Menu
{
    /// <summary>
    /// Контекст меню
    /// </summary>
    public class LibraryMenu
    {
        private readonly Dictionary<string, IMenuState> _states;
        public ILibraryBook Library { get; set; }
        public IFileManagerJson FileManager { get; }

        public LibraryMenu(ILibraryBook library, IFileManagerJson fileManager)
        {
            Library = library;
            FileManager = fileManager;

            // Регистрация состояний
            _states = new Dictionary<string, IMenuState>
        {
            { "1", new AddBookState() },
            { "2", new RemoveBookState() },
            { "3", new GetBookByIdState() },
            { "4", new SearchBooksState() },
            { "5", new ListAllBooksState() },
            { "6", new SaveBooksToJsonState() },
            { "7", new LoadBooksFromJsonState() },
            { "8", new ExitState() }
        };
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить новую книгу");
                Console.WriteLine("2. Удалить книгу");
                Console.WriteLine("3. Найти книгу по идентификатору");
                Console.WriteLine("4. Найти книги по названию");
                Console.WriteLine("5. Показать все книги");
                Console.WriteLine("6. Сохранить все книги в файл");
                Console.WriteLine("7. Считать книги из файла");
                Console.WriteLine("8. Выйти из программы");
                Console.Write("Ваш выбор: ");

                string input = Console.ReadLine();

                if (_states.TryGetValue(input, out var state))
                {
                    state.Handle(this);
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                }
            }
        }
    }

}
