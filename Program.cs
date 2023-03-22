using PlayerSys;
using GameSystems;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.Clear();

            Item goldBag = new Item("goldBag");
            Item goldBag2 = new Item("goldBag");
            Item goldBag3 = new Item("goldBag");

            Console.WriteLine("Item Name: {0}", goldBag.itemName);
            Console.WriteLine("Value: {0}", goldBag.value);
            Console.WriteLine("Item Type: {0}", goldBag.itemType);
            Console.WriteLine("Description: {0}", goldBag.description);
            Console.WriteLine("----------------");
            Console.WriteLine("Item Name: {0}", goldBag2.itemName);
            Console.WriteLine("Value: {0}", goldBag2.value);
            Console.WriteLine("Item Type: {0}", goldBag2.itemType);
            Console.WriteLine("Description: {0}", goldBag2.description);
            Console.WriteLine("----------------");
            Console.WriteLine("Item Name: {0}", goldBag3.itemName);
            Console.WriteLine("Value: {0}", goldBag3.value);
            Console.WriteLine("Item Type: {0}", goldBag3.itemType);
            Console.WriteLine("Description: {0}", goldBag3.description);

            // Player pla = new Player();

            // while (true)
            // {
            //     Console.Write("What do you want to do: ");
            //     string userInput = Console.ReadLine();

            //     switch (userInput)
            //     {
            //         case "gain":
            //             pla.expBar.gainExpericePoints();
            //             break;
            //         case "stats":
            //             Console.WriteLine(pla.name);
            //             // Health Bar Sys.
            //             Console.WriteLine(
            //                 "Health: {0} / {1}",
            //                 pla.healthBar.health,
            //                 pla.healthBar.maxHealth
            //             );
            //             // Mana Bar Sys.
            //             Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);
            //             break;
            //             case "end":
            //                 return;
            //     }
            // }

            // Add a constructor to the health & mana bar to generate for enemies default values
        }
    }
}
