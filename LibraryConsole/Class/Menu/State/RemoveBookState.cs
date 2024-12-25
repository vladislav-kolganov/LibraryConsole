using LibraryConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние удаления книг из бмблиотеки
    /// </summary>
    public class RemoveBookState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            Console.Clear();
            Console.WriteLine("Удаление книги");

            try
            {
                Console.Write("Введите идентификатор: ");
                int id = int.Parse(Console.ReadLine());

                var result = menu.Library.RemoveBook(id);

                if (result.IsSuccess)
                {
                    Console.WriteLine("Книга успешно удалена.");
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
