using LibraryConsole.Class;
using LibraryConsole.Class.Menu;
using LibraryConsole.Interface;

IFileManagerJson fileManagerJson = new LibraryFileManagerJson();
ILibraryBook library = new Library { Books = new List<Book>(fileManagerJson.LoadBooksFromJson()) };

LibraryMenu menu = new LibraryMenu(library, fileManagerJson);

menu.ShowMenu();