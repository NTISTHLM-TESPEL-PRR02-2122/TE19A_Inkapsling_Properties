using System;

namespace TE19A_Inkapsling_Properties
{
  class Program
  {
    static void Main(string[] args)
    {

      Fighter f1 = new Fighter();


      f1.Hp = -900;

      System.Console.WriteLine(f1.Hp);

      f1.Xp += 9000;

      System.Console.WriteLine(f1.Level);


      Console.ReadLine();
      

      // f1.hp -= 200;
      
      // f1.hp = Math.Max(0, f1.hp);



    }
  }
}
