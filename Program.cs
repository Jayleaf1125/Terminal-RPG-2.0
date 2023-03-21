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

            Console.WriteLine(pla.name);
            Console.WriteLine("Health: {0} / {1}", pla.healthBar.health, pla.healthBar.maxHealth);
            Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);

            // Health Bar Sys.
            // Mana Bar Sys.
            // Experince Bar Sys.
        }
    }
}