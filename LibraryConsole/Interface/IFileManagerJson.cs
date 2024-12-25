using LibraryConsole.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Interface
{
    /// <summary>
    /// Интерфейс для методов работы с json файлом для библиотеки книг
    /// </summary>
    public interface IFileManagerJson
    {
        void SaveBooksToJson(List<Book> books);
        List<Book> LoadBooksFromJson();
    }
}
