using LibraryConsole.AbstractClass;
using LibraryConsole.Enum;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class
{

    public class Book : PrintedEdition <BookGenre>
    {
        public Book(int id, string title, string author, int year, BookGenre genre) : base(id, title, author, year, genre)
        {

        }

        public override string ToString()
        {
            return $"Id: {Id}, Название: {Title}, Автор: {Author}, Год: {Year}, Жанр: {Genre}";
        }
    }
}
