using GameSystems;

namespace PlayerSys
{
    class Player
    {
        public string name;
        public HealthSys healthBar = new HealthSys();
        public ManaSys manaBar = new ManaSys();
        public ExpSys expBar;
        public InventorySys backpack;

        public Player()
        {
            // User inputting their name
            Console.Write("What is your name: ");
            string userNameInput = Console.ReadLine();
            this.name = userNameInput.Length == 0 ? "Unknown" : userNameInput;


            this.expBar = new ExpSys(healthBar, manaBar);
            this.backpack = new InventorySys(this);
        }
    }
}
