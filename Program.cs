using System;

namespace HelloWorld;

class Program
{
 static void Main(string[] args)
 {
  // int x; //declaration 
  // x = 123; // initialization   
  //
  // int y = 321; // declaration + initialization
  //
  // Console.WriteLine(x);
  // Console.WriteLine(y);
  //
  //
  // int age = 21; // with int we can only store whole integer
  //
  // Console.WriteLine("Your age is " + age);
  //
  // double height = 3040.333;
  // Console.WriteLine("Your height is " + height + "cm");
  //
  // bool alive = false;// It either true or false
  // Console.WriteLine("Are you alive? " + alive);
  //
  // char  symbol = '@';
  // Console.WriteLine("Your symbol is " + symbol);
  //
  // string name = "Jude";
  // Console.WriteLine("Your name is " + name);
  //
  // // type casting = Converting a value to a different data type 
  // // Useful wehn we accept user input (string)
  // // Different data types can do different things
  //
  // double a = 3.14; 
  // int b = Convert.ToInt32(a);
  // Console.WriteLine(a);
  // Console.WriteLine(b.GetType());
  // Console.WriteLine(b);
  //
  // int c = 123;
  //
  // double d = Convert.ToDouble(c) + 0.11;
  //
  // Console.WriteLine(d);
  //
  // int num = 444;
  // string str = Convert.ToString(num);
  // Console.WriteLine(str);
  // Console.WriteLine(str.GetType());
  //
  // // String to char;
  // string g =  "$";
  // char  h =  Convert.ToChar(g);
  // Console.WriteLine(h);
  //
  // string i = "true";
  // bool j = Convert.ToBoolean(i);
  // Console.WriteLine(j);
  
   Console.WriteLine("What's your name?");
   string name = Console.ReadLine();
   Console.WriteLine("Hello " + name);

 } 

}
