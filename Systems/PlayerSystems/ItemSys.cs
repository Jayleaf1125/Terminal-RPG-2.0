namespace GameSystems
{
    /// <summary>Generates item based on item's name</summary>
    class Item
    {
        public string itemName;
        public int value;
        public string itemType;
        public string description;

        public Item(string itemName)
        {
            switch (itemName)
            {
                case "potion":
                    this.itemName = "potion";
                    this.value = 25;
                    this.itemType = "Healing";
                    this.description = "Regenerates 25 health";
                    break;
                case "goldBag":
                    this.itemName = "goldBag";
                    this.value = new Random().Next(5, 25);
                    this.itemType = "Money";
                    this.description = "Large sum of money";
                    break;
                case "coffee":
                    this.itemName = "coffee";
                    this.value = 2;
                    this.itemType = "Buff";
                    this.description = "Increase your speed by 2";
                    break;
            }
        }
    }
}
