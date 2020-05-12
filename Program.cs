using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Book eloquentJavaScript = new Book("Eloquent Javascript", "Marijn Haverbeke");
      Book introducingPython = new Book("Introducing Python", "Bill Lubanovic");
      Book withoutRemorse = new Book("Without Remorse", "Tom Clancy");
      Book bourneIdentity = new Book("The Bourne Identity", "Robert Ludlum");

      Library myLibrary = new Library("Boise", "Boise Library");
      myLibrary.AddBook(eloquentJavaScript);
      myLibrary.AddBook(introducingPython);
      myLibrary.AddBook(withoutRemorse);
      myLibrary.AddBook(bourneIdentity);

      myLibrary.LibraryGreeting();
      Console.Write(@"
Available Books:

");
      myLibrary.PrintBooks();
      Console.Write(@"
");
      Console.WriteLine("Select a book number to checkout, (Q)uit, or (R)eturn a book");
    }
  }
}
