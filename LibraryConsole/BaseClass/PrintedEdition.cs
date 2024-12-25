namespace LibraryConsole.AbstractClass
{
    /// <summary>
    /// Базовый класс для работы с печатными изданиями    
    /// </summary>
    /// <typeparam name="TGenre"></typeparam>
    public abstract class PrintedEdition<TGenre> where TGenre : System.Enum
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Year { get; set; }

        public TGenre Genre { get; set; }

        public PrintedEdition(int id, string title, string author, int year, TGenre genre)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
        }

    }
}
