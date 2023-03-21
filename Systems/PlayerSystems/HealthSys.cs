namespace GameSystems
{
    /// <summary> Create a health system </summary>
    class HealthSys
    {
        public int health {get; set;}
        public int maxHealth {get; set;}
        public int defense {get; set;}   

        public HealthSys()
        {
            this.maxHealth = new Random().Next(25, 50);
            this.health = maxHealth;
            this.defense = new Random().Next(1, 5);
        }
    }
}