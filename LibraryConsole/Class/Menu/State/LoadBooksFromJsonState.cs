using LibraryConsole.Interface;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние чтения книг из файла
    /// </summary>
    public class LoadBooksFromJsonState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            menu.Library.Books = new(menu.FileManager.LoadBooksFromJson());
            Console.WriteLine("Книги успешно считаны из файла");
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }
}
