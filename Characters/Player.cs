using GameSystems;

namespace PlayerSys
{
    class Player
    {
        /// <summary> Name of player </summary>
        public string name;

        /// <summary> Generates health system for the player </summary>
        public HealthSys healthBar = new HealthSys();

        /// <summary> Generates mana system for the player </summary>
        public ManaSys manaBar = new ManaSys();

        /// <summary> Generates experience system for the player </summary>
        public ExpSys expBar;

        /// <summary> Generates and attaches inventory system to player </summary>
        public InventorySys backpack;

        /// <summary> Generates and attaches money system to player </summary>
        public MoneySys gold;

        public Player()
        {
            // User inputting their name
            Console.Write("What is your name: ");
            string userNameInput = Console.ReadLine();
            this.name = userNameInput.Length == 0 ? "Unknown" : userNameInput;

            this.expBar = new ExpSys(healthBar, manaBar);
            this.backpack = new InventorySys(this);
            this.gold = new MoneySys(this);
        }
    }
}
