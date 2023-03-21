using PlayerSys;

namespace GameSystems
{
    class ExpSys
    {
        public int level = 1;
        public int currentExpAmount = 0;
        public int maxExp = 25;
        public HealthSys healthSys;
        public ManaSys manaSys;

        public ExpSys(HealthSys healthSys, ManaSys manaSys)
        {
            this.healthSys = healthSys;
            this.manaSys = manaSys;
        }

        public void gainExpericePoints()
        {
            // Modify this function to get experince points based on the enemies you fought and their level
            int expGained = new Random().Next(5, 100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You have gained {0} experience points", expGained);
            Console.ForegroundColor = ConsoleColor.White;

            if (currentExpAmount < maxExp && (expGained + currentExpAmount) < maxExp)
            {
                currentExpAmount += expGained;
                return;
            }

            LevelUp();
        }

        private void LevelUp()
        {
            // Adding leftover exp
            int leftOverExp = Math.Abs(currentExpAmount - maxExp);
            level++;
            currentExpAmount = 0;
            currentExpAmount += leftOverExp;
            maxExp += 25;

            // Increasing Stats
            int maxHealthRandomIncrease = new Random().Next(1, 10);
            int maxManaRandomIncrease = new Random().Next(1, 10);
            int defenseRandomIncrease = new Random().Next(1, 5);
            int resistancRandomIncrease = new Random().Next(1, 5);

            healthSys.maxHealth += maxHealthRandomIncrease;
            healthSys.health = healthSys.maxHealth;
            healthSys.defense += defenseRandomIncrease;

            manaSys.maxMana += maxManaRandomIncrease;
            manaSys.mana = manaSys.maxMana;
            manaSys.resistance += resistancRandomIncrease;

            // Display Level Up
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You Leveled Up! You are now Level {0}", level);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Health increased by {0}", maxHealthRandomIncrease);
            Console.WriteLine("Defense increased by {0}", defenseRandomIncrease);
            Console.WriteLine("Mana increased by {0}", maxManaRandomIncrease);
            Console.WriteLine("Resistance increased by {0}", resistancRandomIncrease);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
