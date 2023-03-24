using WorldSystems;
using GameSystems;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            new Main_Gameplay().Main();

            // Add a constructor to the health & mana bar to generate for enemies default values
        }
    }
}
