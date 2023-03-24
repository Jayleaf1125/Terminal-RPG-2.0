using PlayerSys;
using GameSystems;

namespace WorldSystems
{
    class Main_Gameplay
    {
        public void Main()
        {
            Player pla = new Player();

            while (true)
            {
                Console.Write("What do you want to do: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "gain":
                        pla.expBar.gainExpericePoints();
                        break;
                    case "stats":
                        CheckStats(pla);
                        break;
                    case "view exp":
                        pla.expBar.viewExpBar();
                        break;
                    case "collect":
                        pla.backpack.CollectRandomItem();
                        break;
                    case "harm":
                        Console.WriteLine("You took 10 damage");
                        pla.healthBar.health -= 10;
                        break;
                    case "use":
                        UseCase(pla);
                        break;
                    case "view bag":
                        pla.backpack.ViewBackpackContents();
                        break;
                    case "add":
                        pla.gold.Deposit(new Random().Next(1, 10));
                        break;
                    case "drop":
                        pla.gold.Withdraw(5);
                        break;
                    case "end":
                        return;
                }
            }
        }

        private static void UseCase(Player pla)
        {
            while (true)
            {
                if (pla.backpack.isEmpty())
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You aint nothing to use, poor much?");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                Console.Write("What item do you want to use: ");
                string userInputVal = Console.ReadLine();

                if (userInputVal == "exit")
                    break;

                if (pla.backpack.Use(userInputVal) == "Unsuccessful")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Item name does not exist");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        private void CheckStats(Player pla)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(pla.name);
            // Health Bar Sys.
            Console.WriteLine("Health: {0} / {1}", pla.healthBar.health, pla.healthBar.maxHealth);
            // Mana Bar Sys.
            Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);
            // Experience Sys.
            Console.WriteLine(
                "Experince: {0} / {1}",
                pla.expBar.currentExpAmount,
                pla.expBar.maxExp
            );
            // Money Sys.
            pla.gold.CurrentAmount();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
