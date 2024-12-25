using LibraryConsole.Class.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Interface
{
    /// <summary>
    /// Интерфейс определяет метод Handle, который реализуют все конкретные состояния.
    /// </summary>
    public interface IMenuState
    {
        void Handle(LibraryMenu menu);
    }

}
