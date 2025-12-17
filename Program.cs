namespace Myapp;

using Myapp.Models;

class Program
{
    public static void Main()
    {
        var p = new Person{Name="Alan"};
        p.Age();
        p.Run();
        Console.WriteLine(p.Name + " heh");
    }
}
