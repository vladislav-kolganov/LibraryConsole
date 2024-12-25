using LibraryConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    ///  Состояния для вывода всех книг
    /// </summary>
    public class ListAllBooksState : IMenuState

    {
        public void Handle(LibraryMenu menu)
        {
            menu.Library.ListAllBooks();

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
        }
    }
}
