using System.Security.Cryptography;

namespace rpsgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            List<string> rpslist = new List<string>{"rock", "paper", "scissors","Exit"};
            Random randomnumber = new Random();
            int pcwin = 0;
            int mywin = 0;
            int ties = 0;

            while (run)
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Please select an option (you can also write out the word): ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    option = "rock";
                } else if (option == "2")
                {
                    option = "paper";
                } else if (option == "3")
                {
                    option = "scissors";
                } else if (option == "4")
                {
                    option = "exit";
                }

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
                            ties++;
                        } else if (rpslist[choice] == "paper")
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                            pcwin++;
                        } else
                        {
                            Console.WriteLine("Computer's choice is... scissors");
                            Console.WriteLine("You won!");
                            Console.WriteLine();
                            mywin++;
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
                            ties++;
                        } else if (rpslist[choice2] == "scissors")
                        {
                            Console.WriteLine("Computer's choice is... scissors");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
                        {
                            Console.WriteLine("Computer's choice is... rock");
                            Console.WriteLine("You won!");
                            Console.WriteLine();
                            mywin++;
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
                            ties++;
                        }
                        else if (rpslist[choice3] == "rock")
                        {
                            Console.WriteLine("Computer's choice is... rock");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("You won!");
                            Console.WriteLine();
                            mywin++;
                        }
                        break;
                    case "exit":
                        Console.Clear();
                        Console.WriteLine("Exiting...");
                        Console.WriteLine($"Computer wins: {pcwin}");
                        Console.WriteLine($"Your wins: {mywin}");
                        Console.WriteLine($"Ties: {ties}");
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("The computer couldn't understand the choice...");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
