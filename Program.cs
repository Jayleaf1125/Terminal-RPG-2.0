using PlayerSys;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.Clear();

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
                    case "check": 
                        Console.WriteLine(pla.name);
                        // Health Bar Sys.
                        Console.WriteLine(
                            "Health: {0} / {1}",
                            pla.healthBar.health,
                            pla.healthBar.maxHealth
                        );
                        // Mana Bar Sys.
                        Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);
                        break;
                        case "end":
                            return;
                }
            }

            // Add a constructor to the health & mana bar to generate for enemies default values
        }
    }
}
