using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_77
{
    internal class book: Product
    {
         public string Genre { get; set; }

    public book(int no, double price, string name, string genre)
    {
        No = no;
        Price = price;
        Name = name;
        Genre = genre;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"No: {No}, Name: {Name}, Price: {Price}, Genre: {Genre}");
    }

    }
}
