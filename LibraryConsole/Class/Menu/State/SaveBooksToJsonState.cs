using LibraryConsole.Class;
using LibraryConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние сохранения книг в файл 
    /// </summary>
    public class SaveBooksToJsonState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            menu.FileManager.SaveBooksToJson(menu.Library.Books);
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }
}
