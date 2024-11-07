using System.Security.Cryptography;

namespace rpsgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. English");
            Console.WriteLine("2. Hungarian");
            Console.WriteLine();
            Console.Write("Please choose a language: ");
            int selectedLang = int.Parse(Console.ReadLine());

            switch (selectedLang)
            {
                case 1:
                    Console.Clear();
                    english();
                    break;
                case 2:
                    Console.Clear();
                    hungarian();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("The computer couldn't understand the choice...");
                    break;
            }
        }
        static void english()
        {
            bool run = true;
            List<string> rpslist = new List<string> { "rock", "paper", "scissors", "Exit" };
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
                }
                else if (option == "2")
                {
                    option = "paper";
                }
                else if (option == "3")
                {
                    option = "scissors";
                }
                else if (option == "4")
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
                        }
                        else if (rpslist[choice] == "paper")
                        {
                            Console.WriteLine("Computer's choice is... paper");
                            Console.WriteLine("Computer won!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
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
                        }
                        else if (rpslist[choice2] == "scissors")
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
                        Console.WriteLine();
                        Console.WriteLine($"Computer wins: {pcwin}");
                        Console.WriteLine($"Your wins: {mywin}");
                        Console.WriteLine($"Ties: {ties}");
                        Console.ReadLine();
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
        static void hungarian()
        {
            bool run = true;
            List<string> rpslist = new List<string> { "kő", "papír", "olló", "kilépés" };
            Random randomnumber = new Random();
            int pcwin = 0;
            int mywin = 0;
            int ties = 0;

            while (run)
            {
                Console.WriteLine("1. Kő");
                Console.WriteLine("2. Papír");
                Console.WriteLine("3. Olló");
                Console.WriteLine("4. Kilépés");
                Console.WriteLine();
                Console.Write("Kérlek válasz egy opciót (a szót is be lehet írni): ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    option = "kő";
                }
                else if (option == "2")
                {
                    option = "papír";
                }
                else if (option == "3")
                {
                    option = "olló";
                }
                else if (option == "4")
                {
                    option = "Kilépés";
                }

                switch (option.ToLower())
                {
                    case "kő":
                        Console.Clear();
                        int choice = randomnumber.Next(0, 3);
                        if (option == rpslist[choice])
                        {
                            Console.WriteLine("A gép válasza... kő");
                            Console.WriteLine("Döntetlen!");
                            Console.WriteLine();
                            ties++;
                        }
                        else if (rpslist[choice] == "papír")
                        {
                            Console.WriteLine("A gép válasza... papír");
                            Console.WriteLine("A gép nyert!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
                        {
                            Console.WriteLine("A gép válasza... olló");
                            Console.WriteLine("Te nyertél!");
                            Console.WriteLine();
                            mywin++;
                        }
                        break;
                    case "papír":
                        Console.Clear();
                        int choice2 = randomnumber.Next(0, 3);
                        if (option == rpslist[choice2])
                        {
                            Console.WriteLine("A gép válasza... papír");
                            Console.WriteLine("Döntetlen!");
                            Console.WriteLine();
                            ties++;
                        }
                        else if (rpslist[choice2] == "olló")
                        {
                            Console.WriteLine("A gép válasza... olló");
                            Console.WriteLine("A gép nyert!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
                        {
                            Console.WriteLine("A gép válasza... kő");
                            Console.WriteLine("Te nyertél!");
                            Console.WriteLine();
                            mywin++;
                        }
                        break;
                    case "olló":
                        Console.Clear();
                        int choice3 = randomnumber.Next(0, 3);
                        if (option == rpslist[choice3])
                        {
                            Console.WriteLine("A gép válasza... olló");
                            Console.WriteLine("Döntetlen!");
                            Console.WriteLine();
                            ties++;
                        }
                        else if (rpslist[choice3] == "kő")
                        {
                            Console.WriteLine("A gép válasza... kő");
                            Console.WriteLine("A gép nyert!");
                            Console.WriteLine();
                            pcwin++;
                        }
                        else
                        {
                            Console.WriteLine("A gép válasza... papír");
                            Console.WriteLine("Te nyertél!");
                            Console.WriteLine();
                            mywin++;
                        }
                        break;
                    case "kilépés":
                        Console.Clear();
                        Console.WriteLine("Kilépés...");
                        Console.WriteLine();
                        Console.WriteLine($"A gép ennyiszer nyert: {pcwin}");
                        Console.WriteLine($"Te ennyiszer nyertél: {mywin}");
                        Console.WriteLine($"Döntetlenek: {ties}");
                        Console.ReadLine();
                        run = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("A gép nem tudta értelmezni a mondanivalód...");
                        Console.WriteLine();
                        break;
                }

            }
        }
    }
}
