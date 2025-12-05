class Crack
{
    public static void Main()
    {
        string password = "";
        Console.WriteLine("Enter you password: ");
        password = Console.ReadLine()!;
        if (password == "user")
        {
           Console.WriteLine("Damn u r right!"); 
        }else
        {
            Console.WriteLine("Bad credential!");
        }
        
    }
}
