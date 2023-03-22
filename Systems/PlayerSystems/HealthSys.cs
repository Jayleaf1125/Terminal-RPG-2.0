namespace GameSystems
{
    /// <summary> Create a health system</summary>
    class HealthSys
    {
        public int health { get; set; }
        public int maxHealth { get; set; }
        public int defense { get; set; }

        public HealthSys()
        {
            this.maxHealth = new Random().Next(25, 50);
            this.health = maxHealth;
            this.defense = new Random().Next(1, 5);
        }

        public HealthSys(string enemyType)
        {
            switch (enemyType)
            {
                case "rat":
                    this.maxHealth = new Random().Next(5, 15);
                    this.health = maxHealth;
                    this.defense = new Random().Next(1, 5);
                    break;
                case "spider":
                    this.maxHealth = new Random().Next(25, 40);
                    this.health = maxHealth;
                    this.defense = new Random().Next(5, 15);
                    break;
                case "golem":
                    this.maxHealth = new Random().Next(50, 70);
                    this.health = maxHealth;
                    this.defense = new Random().Next(15, 30);
                    break;
            }
        }
    }
}
