namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;
        private static int powerupCount;

        public Foe(string name)
        {
            this.SetName(name);
            health = 100;
            shield = 0;
        }
        public static Foe()
        {
            powerupCount = 0;
        }

        public string GetName() => name;

        public float GetHealth() => health;

        public float GetShield() => shield;

        public static int GetPowerupCount() => powerupCount;


        public void SetName(string name)
        {
            this.name = name.Trim();
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerup, float bonus)
        {
            if (powerup == PowerUp.Health)
            {
                health += bonus;
                if (health > 100)
                    health = 100;
            }
            if (powerup == PowerUp.Shield)
            {
                shield += bonus;
                if (shield > 100)
                    shield = 100;
            }
            
            powerupCount += 1;
        }




    }
}