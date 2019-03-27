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

      Console.WriteLine("Welcome to Rock, Paper, Scissors");
      bool duelling = true;
      Random mathRandomTool = new Random();
      while (duelling)
      {
        Console.Write("Type rock, paper, or scissors: ");
        string input = Console.ReadLine().ToLower();

        string[] cpu = new string[3];
        cpu[0] = "rock";
        cpu[1] = "paper";
        cpu[2] = "scissors";

        int number = mathRandomTool.Next(0, cpu.Length);
        string cpuChoice = cpu[number];

        if (input == "rock")
        {
          if (cpuChoice == "rock")
          {
            Console.WriteLine("DRAW... try again");
          }
          else if (cpuChoice == "scissors")
          {
            Console.WriteLine("YOU WIN!");
          }
          else if (cpuChoice == "paper")
          {
            Console.WriteLine("YOU LOSE... try again");
          }
          else
          {
            Console.WriteLine("I DONT WORK WITH BAD DATA!!!");
            continue;
          }
        }
        if (input == "scissors")
        {
          if (cpuChoice == "scissors")
          {
            Console.WriteLine("DRAW... try again");
          }
          else if (cpuChoice == "paper")
          {
            Console.WriteLine("YOU WIN!");
          }
          else if (cpuChoice == "rock")
          {
            Console.WriteLine("YOU LOSE... try again");
          }
          else
          {
            Console.WriteLine("I DONT WORK WITH BAD DATA!!!");
            continue;
          }
        }
        if (input == "paper")
        {
          if (cpuChoice == "paper")
          {
            Console.WriteLine("DRAW... try again");
          }
          else if (cpuChoice == "rock")
          {
            Console.WriteLine("YOU WIN!");
          }
          else if (cpuChoice == "scissors")
          {
            Console.WriteLine("YOU LOSE... try again");
          }
          else
          {
            Console.WriteLine("I DONT WORK WITH BAD DATA!!!");
            continue;
          }

        }
      }
    }
  }
}
