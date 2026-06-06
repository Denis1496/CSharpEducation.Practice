namespace Practice3_Task5;

class The_Book
{
    public String Name;
    public String Author;
    public int years;

    public The_Book(string name, string author, int years)
    {
        Name = name;
        Author = author;
        this.years = years;
    }

    public The_Book()
    {
        Name = "Unknown";
        Author = "Unknown";;
        years = 10;;

    }
}


class Program
{
    static void Main(string[] args)
    {
        The_Book book = new The_Book("Denis", "The Book", 24);
        Console.WriteLine(book.Name, book.Author);
        Console.WriteLine(book.Author);
        Console.WriteLine(book.years);
        The_Book book2 = new The_Book("Denis14", "The Book96", 25);
        Console.WriteLine(book2.Name);
        Console.WriteLine(book2.Author);
        Console.WriteLine(book2.years);
    }
}