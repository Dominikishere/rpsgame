using System.Security.Cryptography;

namespace rpsgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            List<string> rpslist = new List<string>{"rock", "paper", "scissors"};
            Random randomnumber = new Random();

            while (run)
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Please select an option (you can also write out the word): ");
                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "rock":
                        Console.Clear();
                        int choice = randomnumber.Next(0, 3);
                        if (option == rpslist[choice])
                        {
                            Console.WriteLine("Computer's choice is... rock");
                            Console.WriteLine("Tie!");
                            Console.WriteLine();
                        } else if (rpslist[choice] == "paper")
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                        } else
                        {
                            Console.WriteLine("Computer's choice is... scissors");
                            Console.WriteLine("you won!");
                            Console.WriteLine();
                        }
                        break;
                    case "paper":
                        Console.Clear();
                        int choice2 = randomnumber.Next(0, 3);
                        if (option == rpslist[choice2])
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("Tie!");
                            Console.WriteLine();
                        }
                        else if (rpslist[choice2] == "scissors")
                        {
                            Console.WriteLine("Computer's choice is... scissors");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Computer's choice is... rock");
                            Console.WriteLine("you won!");
                            Console.WriteLine();
                        }
                        break;
                    case "scissors":
                        Console.Clear();
                        int choice3 = randomnumber.Next(0, 3);
                        if (option == rpslist[choice3])
                        {
                            Console.WriteLine("Computer's choice is... scissors");
                            Console.WriteLine("Tie!");
                            Console.WriteLine();
                        }
                        else if (rpslist[choice3] == "rock")
                        {
                            Console.WriteLine("Computer's choice is... rock");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("you won!");
                            Console.WriteLine();
                        }
                        break;
                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Exiting...");
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("The computer couldn't understand the choice...");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
