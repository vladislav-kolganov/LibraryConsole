using LibraryConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние завершение программы
    /// </summary>
    public class ExitState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            Console.WriteLine("Выход из программы...");
            Environment.Exit(0);
        }
    }
}
