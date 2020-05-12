using System.Collections.Generic;


namespace console_library.Models
{
  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }

    private List<Book> Books { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book> { };
    }

    public void LibraryGreeting()
    {
      System.Console.WriteLine($"Welcome to the {Location} Library!");
    }
    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1}) {Books[i].Title} - {Books[i].Author}");
      }
    }
    public void AddBook(Book book)
    {
      Books.Add(book);
    }
  }
}