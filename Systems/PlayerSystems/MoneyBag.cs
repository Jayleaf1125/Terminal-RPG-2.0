using PlayerSys;

namespace GameSystems
{
    class MoneySys
    {
        /// <summary> The amount of gold the player has currently </summary>
        int pouch = 0;

        /// <summary> Attached to the assign player </summary>
        Player player;

        public MoneySys(Player player)
        {
            this.player = player;
        }

        public void Deposit(int gold)
        {
            pouch += gold;
            Console.WriteLine("You deposited {0} gold", gold);
        }

        public void Withdraw(int gold)
        {
            pouch -= gold;
            Console.WriteLine("You withdrew {0} gold", gold);
        }

        public void CurrentAmount()
        {
            Console.WriteLine("You currently have {0} gold", pouch);
        }
    }
}
