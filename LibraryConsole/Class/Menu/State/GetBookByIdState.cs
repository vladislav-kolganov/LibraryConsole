using LibraryConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsole.Class.Menu.State
{
    /// <summary>
    /// Состояние получение книги по id 
    /// </summary>
    public class GetBookByIdState : IMenuState
    {
        public void Handle(LibraryMenu menu)
        {
            Console.Clear();
            Console.WriteLine("Поиск книги по Id");

            try
            {
                Console.Write("Введите идентификатор: ");
                int id = int.Parse(Console.ReadLine());

                var result = menu.Library.GetBookById(id);

                if (result.IsSuccess)
                {
                    Console.WriteLine("Найденная книга:");
                    Console.WriteLine(result.Data.ToString());
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
