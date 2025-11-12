using System;

namespace HelloWorld;

class Program
{
 static void Main(string[] args)
 {
  int x; //declaration 
  x = 123; // initialization   

  int y = 321; // declaration + initialization

  Console.WriteLine(x);
  Console.WriteLine(y);


  int age = 21; // with int we can only store whole integer

  Console.WriteLine("Your age is " + age);

  double height = 3040.333;
  Console.WriteLine("Your height is " + height + "cm");

  bool alive = false;// It either true or false
  Console.WriteLine("Are you alive? " + alive);

  char  symbol = '@';
  Console.WriteLine("Your symbol is " + symbol);

  string name = "Jude";
  Console.WriteLine("Your name is " + name);
 } 
}
