using GameSystems;

namespace PlayerSys 
{
    class Player
    {
        public string name;
        public HealthSys healthBar = new HealthSys();
        public ManaSys manaBar = new ManaSys();

        public Player()
        {
            Console.Write("What is your name: ");
            this.name = Console.ReadLine();
        }
    }
}