namespace GameSystems
{

    /// <summary> Create a mana system </summary>
    class ManaSys
    {
        public int mana {get; set;}
        public int maxMana {get; set;}
        public int resistance {get; set;}
        // Random rnd = new Random()

        public ManaSys()
        {
            this.maxMana = new Random().Next(10, 25);
            this.mana = maxMana;
            this.resistance = new Random().Next(1, 5);
        }
    }
}