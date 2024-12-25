using LibraryConsole.Class;
using LibraryConsole.Interface;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibraryConsole.Class
{
    
    public class LibraryFileManagerJson : IFileManagerJson
    {
        private readonly string _filePath = "books.json";

       /// <summary>
       /// Метод записи коллекции книг в файл json
       /// </summary>
       /// <param name="books"></param>
        public void SaveBooksToJson(List<Book> books)
        {
            try
            {

                var json = JsonSerializer.Serialize(books);
   
                File.WriteAllText(_filePath, json);
            
                Console.WriteLine("Книги успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        /// <summary>
        /// Метод чтения коллекции книг файл json
        /// </summary>
        /// <returns></returns>
        public List<Book> LoadBooksFromJson()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Console.WriteLine("Файл не найден. Начинается работа с пустой библиотекой.");
                    return new List<Book>();
                }

                string json = File.ReadAllText(_filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    Console.WriteLine("Файл пуст. Начинается работа с пустой библиотекой.");
                    return new List<Book>();
                }

                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } 
                };

                return JsonSerializer.Deserialize<List<Book>>(json, options) ?? new List<Book>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении из файла: {ex.Message}");
                return new List<Book>();
            }

        }
    }
}
