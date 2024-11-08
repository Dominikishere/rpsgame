using System.Security.Cryptography;

namespace rpsgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string language = languageSelector();

            if (language == "english")
            {
                string wantToWagerEngAnswer = wantToWagerEng();
                if (wantToWagerEngAnswer == "yes")
                {
                    english(engbalance: 100);
                } else if (wantToWagerEngAnswer == "no")
                {
                    english();
                }

            } else if (language == "magyar")
            {
                string wantToWagerHunAnswer = wantToWagerHun();
                if (wantToWagerHunAnswer == "igen")
                {
                    hungarian(hunbalance: 5000);
                } else if (wantToWagerHunAnswer == "nem")
                {
                    hungarian();
                }
            }
        }
        static string wantToWagerEng()
        {
            Console.WriteLine("Do you want to play with money balance? (you start with 100$ and you win money by winning against the machine)\n");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine();
            Console.Write("Please write your answer: ");
            string wantToWageranswer = Console.ReadLine();

            if (wantToWageranswer == "1")
            {
                wantToWageranswer = "yes";
            }
            else if (wantToWageranswer == "2")
            {
                wantToWageranswer = "no";
            }

            switch (wantToWageranswer)
            {
                case "yes": 
                    Console.Clear();
                    return "yes";
                case "no":
                    Console.Clear();
                    return "no";
                default:
                    Console.Clear();
                    Console.WriteLine("The computer couldn't understand the choice...");
                    return wantToWagerEng();
            }
        }
        static string wantToWagerHun()
        {
            Console.WriteLine("Szeretnél egyenleggel játszani? (5000 forinttal kezdesz, ha nyersz akkor az egyenleged növekszik)\n");
            Console.WriteLine("1. Igen");
            Console.WriteLine("2. Nem");
            Console.WriteLine();
            Console.Write("Kérlek adj meg egy választ: ");
            string wantToWageranswer = Console.ReadLine();

            if (wantToWageranswer == "1")
            {
                wantToWageranswer = "igen";
            }
            else if (wantToWageranswer == "2")
            {
                wantToWageranswer = "nem";
            }

            switch (wantToWageranswer)
            {
                case "igen":
                    Console.Clear();
                    return "igen";
                case "nem":
                    Console.Clear();
                    return "nem";
                default:
                    Console.Clear();
                    Console.WriteLine("The computer couldn't understand the choice...");
                    return wantToWagerHun();
            }
        }
        static string languageSelector()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!\n");
            Console.WriteLine("1. English");
            Console.WriteLine("2. Magyar");
            Console.WriteLine();
            Console.Write("Please choose a language: ");
            string selectedLang = Console.ReadLine();

            if (selectedLang == "1")
            {
                selectedLang = "english";
            }
            else if (selectedLang == "2")
            {
                selectedLang = "magyar";
            }

            switch (selectedLang.ToLower())
            {
                case "english":
                    Console.Clear();
                    return "english";
                case "magyar":
                    Console.Clear();
                    return "magyar";
                default:
                    Console.Clear();
                    Console.WriteLine("The computer couldn't understand the choice...");
                    return languageSelector();
            }
        }
        static void english(int engbalance = 0)
        {
            bool run = true;
            bool wagerEnabling = engbalance > 0;
            List<string> rpslist = new List<string> { "rock", "paper", "scissors", "shop", "Exit" };
            Random randomnumber = new Random();
            int pcwin = 0;
            int mywin = 0;
            int ties = 0;

            while (run)
            {
                if (wagerEnabling && engbalance <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You ran out of money! Game over!");
                    Thread.Sleep(3000);
                    System.Environment.Exit(0);
                } else
                {
                    Console.WriteLine("1. Rock");
                    Console.WriteLine("2. Paper");
                    Console.WriteLine("3. Scissors");
                    Console.WriteLine();
                    Console.WriteLine("4. Shop (SOON)");
                    Console.WriteLine("5. Exit");
                    if (engbalance > 0)
                    {
                        Console.WriteLine($"Your current balance: {engbalance}$");
                    }
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
                        option = "shop";
                    }
                    else if (option == "5")
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
                                if (wagerEnabling)
                                {
                                    engbalance -= 10;
                                    Console.WriteLine("You lost 10$!");
                                }
                                Console.WriteLine();
                                pcwin++;


                            }
                            else
                            {
                                Console.WriteLine("Computer's choice is... scissors");
                                Console.WriteLine("You won!");
                                if (wagerEnabling)
                                {
                                    engbalance += 10;
                                    Console.WriteLine("You won 10$!");
                                }
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
                                if (wagerEnabling)
                                {
                                    engbalance -= 10;
                                    Console.WriteLine("You lost 10$!");
                                }
                                Console.WriteLine();
                                pcwin++;
                            }
                            else
                            {
                                Console.WriteLine("Computer's choice is... rock");
                                Console.WriteLine("You won!");
                                if (wagerEnabling)
                                {
                                    engbalance += 10;
                                    Console.WriteLine("You won 10$!");
                                }
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
                                if (wagerEnabling)
                                {
                                    engbalance -= 10;
                                    Console.WriteLine("You lost 10$!");
                                }
                                Console.WriteLine();
                                pcwin++;

                            }
                            else
                            {
                                Console.WriteLine("Computer's choice is... paper");
                                Console.WriteLine("You won!");
                                if (wagerEnabling)
                                {
                                    engbalance += 10;
                                    Console.WriteLine("You won 10$!");
                                }
                                Console.WriteLine();
                                mywin++;
                            }
                            break;
                        case "shop":
                            Console.Clear();
                            Console.WriteLine("Shop is under development");
                            Thread.Sleep(2000);
                            Console.Clear();
                            break;
                        case "exit":
                            Console.Clear();
                            Console.WriteLine("Exiting in 5 seconds...\n");
                            Console.WriteLine($"Computer wins: {pcwin}");
                            Console.WriteLine($"Your wins: {mywin}");
                            Console.WriteLine($"Ties: {ties}");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
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
        static void hungarian(int hunbalance = 0)
        {
            bool run = true;
            bool wagerEnabling = hunbalance > 0;
            List<string> rpslist = new List<string> { "kő", "papír", "olló", "bolt", "kilépés" };
            Random randomnumber = new Random();
            int pcwin = 0;
            int mywin = 0;
            int ties = 0;

            while (run)
            {
                if (wagerEnabling && hunbalance <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Elfogyott a pénzed!");
                    Thread.Sleep(3000);
                    System.Environment.Exit(0);
                } else
                {
                    Console.WriteLine("1. Kő");
                    Console.WriteLine("2. Papír");
                    Console.WriteLine("3. Olló");
                    Console.WriteLine();
                    Console.WriteLine("4. Bolt");
                    Console.WriteLine("5. Kilépés");
                    Console.WriteLine();
                    if (hunbalance > 0)
                    {
                        Console.WriteLine($"A jelenlegi egyenleged: {hunbalance}ft");
                    }
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
                        option = "bolt";
                    }
                    else if (option == "5")
                    {
                        option = "kilépés";
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
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Vesztettél 500 forintot!");
                                    hunbalance -= 500;
                                }
                                Console.WriteLine();
                                pcwin++;
                            }
                            else
                            {
                                Console.WriteLine("A gép válasza... olló");
                                Console.WriteLine("Te nyertél!");
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Nyertél 500 forintot!");
                                    hunbalance += 500;
                                }
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
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Vesztettél 500 forintot!");
                                    hunbalance -= 500;
                                }
                                Console.WriteLine();
                                pcwin++;
                            }
                            else
                            {
                                Console.WriteLine("A gép válasza... kő");
                                Console.WriteLine("Te nyertél!");
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Nyertél 500 forintot!");
                                    hunbalance += 500;
                                }
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
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Vesztettél 500 forintot!");
                                    hunbalance -= 500;
                                }
                                Console.WriteLine();
                                pcwin++;
                            }
                            else
                            {
                                Console.WriteLine("A gép válasza... papír");
                                Console.WriteLine("Te nyertél!");
                                if (wagerEnabling)
                                {
                                    Console.WriteLine("Nyertél 500 forintot!");
                                    hunbalance += 500;
                                }
                                Console.WriteLine();
                                mywin++;
                            }
                            break;
                        case "bolt":
                            Console.Clear();
                            Console.WriteLine("A bolt fejlesztés alatt áll...");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                        case "kilépés":
                            Console.Clear();
                            Console.WriteLine("Kilépés 5 másodperc múlva...\n");
                            Console.WriteLine();
                            Console.WriteLine($"A gép ennyiszer nyert: {pcwin}");
                            Console.WriteLine($"Te ennyiszer nyertél: {mywin}");
                            Console.WriteLine($"Döntetlenek: {ties}");
                            Thread.Sleep(5000);
                            System.Environment.Exit(0);
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
}
