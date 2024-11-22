using System;

class Program {
  static void Main(){
    String[] Stringarray = { "one", "two", "three" };
    foreach (String element in Stringarray)
    {
    Console.WriteLine(element + " ");
    }
    Console.Read();
  }
}
