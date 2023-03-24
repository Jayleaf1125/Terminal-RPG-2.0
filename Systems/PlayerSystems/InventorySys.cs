using PlayerSys;

namespace GameSystems
{
    class InventorySys
    {
        List<Item> storage;
        int backpackSize = 0;

        Player player;

        public InventorySys(Player player)
        {
            this.storage = new List<Item>();
            this.player = player;
        }

        public void Store(Item item)
        {
            storage.Add(item);
            backpackSize++;
        }

        public void Use(string item)
        {
            switch (item)
            {
                case "potion":
                    // Condition 1: Regular Healing
                    // Condition 2: Healing can cause overflow in health bar
                    // Condition 3: If player's health is maxed out
                    for (int i = 0; i < storage.Count; i++)
                    {
                        if (storage[i].itemName == "potion")
                        {
                            if (player.healthBar.health == player.healthBar.maxHealth)
                            {
                                Console.WriteLine("Current health is full");
                                return;
                            }
                            else if (
                                (player.healthBar.health + storage[i].value)
                                > player.healthBar.maxHealth
                            )
                            {
                                player.healthBar.health = player.healthBar.maxHealth;
                                storage.RemoveAt(i);
                                backpackSize--;
                                Console.WriteLine("{0}'s health is now maxed", player.name);
                                return;
                            }
                            else
                            {
                                player.healthBar.health += storage[i].value;
                                Console.WriteLine("{0} healed by 25 points", player.name);
                                Drop(i);
                                return;
                            }
                        }
                    }
                    Console.WriteLine("You do not have a potion");
                    break;
            }
        }

        public void Drop(int i)
        {
            storage.RemoveAt(i);
            backpackSize--;
            return;
        }

        public void CollectRandomItem()
        {
            Console.WriteLine("You have collected a potion");
            Store(new Item("potion"));
        }

        public void ViewBackpackContents()
        {
            if (backpackSize == 0)
            {
                Console.WriteLine("Bag is empty");
                return;
            }

            for (int i = 0; i < storage.Count; i++)
            {
                Console.WriteLine("{0}) {1}", i + 1, storage[i].itemName);
            }
        }

        // public void Sell()
    }
}
