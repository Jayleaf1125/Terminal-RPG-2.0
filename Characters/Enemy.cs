using GameSystems;

namespace PlayerSys
{
    class Enemies
    {
        public string enemyType;
        public HealthSys healthBar;
        public int level;

        public Enemies(string enemyType)
        {
            switch (enemyType)
            {
                case "rat":
                    this.enemyType = "rat";
                    this.level = new Random().Next(1, 5);
                    this.healthBar = new HealthSys("rat");
                    break;
                case "spider":
                    this.enemyType = "spider";
                    this.level = new Random().Next(5, 10);
                    this.healthBar = new HealthSys("spider");
                    break;
                case "golem":
                    this.level = new Random().Next(10, 15);
                    this.enemyType = "golem";
                    this.healthBar = new HealthSys("golem");
                    break;
            }
        }
    }
}
