using System;
//import or require


//controlling access amongst files
namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      // Console.Write("What is your name: ");
      // string name = Console.ReadLine();
      // Console.WriteLine("Hello " + name);
      // bool valid = false;
      // while (!valid)
      // {
      //     Console.Write("How old are you: ");
      //     string strAge = Console.ReadLine();
      //     int age;
      //     if (Int32.TryParse(strAge, out age))
      //     {
      //         valid = true;
      //         System.Console.WriteLine($"In 10 years you will be {age + 10}");
      //     }
      //     else
      //     {
      //         Console.Beep();
      //         System.Console.WriteLine("Please provide a valid number");
      //     }
      // }

      //Given user input of a dice number and sides (1d6, 1d4, 3d8, 1d7)

      //     Console.WriteLine("Welcome to the DiceRoller5000");
      //     bool rolling = true;
      //     Random mathRandomTool = new Random();
      //     while (rolling)
      //     {
      //         System.Console.Write("ENTER DICE :");
      //         string input = Console.ReadLine().ToLower();
      //         string[] arrInputs = input.Split('d');
      //         int rolls;
      //         int sides;
      //         if (arrInputs.Length < 1 || !Int32.TryParse(arrInputs[0], out rolls) || !Int32.TryParse(arrInputs[1], out sides))
      //         {
      //             Console.WriteLine("I DONT WORK WITH BAD DATA!!!");
      //             continue;
      //         }
      //         int[] results = new int[rolls];
      //         int total = 0;
      //         for (int i = 0; i < rolls; i++)
      //         {
      //             int number = mathRandomTool.Next(1, sides + 1);
      //             results[i] = number;
      //             Console.Write(number + " ");
      //             total += number;
      //         }
      //         Console.WriteLine(Environment.NewLine);
      //         System.Console.WriteLine($"TOTAL: {total}");
      //     }

      // }

      Console.WriteLine("Welcome to the Rock, Paper, Scissors");
      bool rolling = true;
      Random mathRandomTool = new Random();
      while (rolling)
      {
        Console.Write("ENTER ATTACK :");
        string input = Console.ReadLine().ToLower();

        if (input == "rock")
        {
          if (cpu == "rock")
          {
            Console.WriteLine("DRAW... try again");
          }
          else if (cpu == "scissors")
          {
            Console.WriteLine("YOU WIN!");
          }
          else if (cpu == "paper")
          {
            Console.WriteLine("YOU LOSE... try again");
          }
        }
        {
          Console.WriteLine("I DONT WORK WITH BAD DATA!!!");
          continue;
        }
        int[] results = new int[rolls];
        int total = 0;
        for (int i = 0; i < rolls; i++)
        {
          int number = mathRandomTool.Next(1, sides + 1);
          results[i] = number;
          Console.Write(number + " ");
          total += number;
        }
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"TOTAL: {total}");
      }

    }
  }
}
