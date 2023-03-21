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
            // Health Bar Sys.
            Console.WriteLine("Health: {0} / {1}", pla.healthBar.health, pla.healthBar.maxHealth);
            // Mana Bar Sys.
            Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);
            // Experince Bar Sys.
            pla.expBar.gainExpericePoints();
            pla.expBar.gainExpericePoints();
            pla.expBar.gainExpericePoints();
            pla.expBar.gainExpericePoints();
            // pla.expBar.gainExpericePoints();
            Console.WriteLine("-----------");
            Console.WriteLine(pla.name);
            // Health Bar Sys.
            Console.WriteLine("Health: {0} / {1}", pla.healthBar.health, pla.healthBar.maxHealth);
            // Mana Bar Sys.
            Console.WriteLine("Mana: {0} / {1}", pla.manaBar.mana, pla.manaBar.maxMana);

            // Add a constructor to the health & mana bar to generate for enemies default values
        }
    }
}