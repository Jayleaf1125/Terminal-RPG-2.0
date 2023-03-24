using PlayerSys;
using GameSystems;

namespace WorldSystems
{
    class Main_Gameplay
    {
        public void MainGameplay()
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(pla.name);
                        // Health Bar Sys.
                        Console.WriteLine(
                            "Health: {0} / {1}",
                            pla.healthBar.health,
                            pla.healthBar.maxHealth
                        );
                        // Mana Bar Sys.
                        Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);
                        Console.ForegroundColor = ConsoleColor.White;
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
                            pla.backpack.Use("potion");
                        break;
                        case "view bag":
                            pla.backpack.ViewBackpackContents();
                        break;
                    case "end":
                        return;
                }
            }
        }
    }
}
