namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        public Foe(string name)
        {
            this.SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName() => name;

        public float GetHealth() => health;

        public float GetShield() => shield;


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
                this.health += bonus;
                if (this.health > 100)
                    this.health = 100;
            }
            if (powerup == PowerUp.Shield)
            {
                this.shield += bonus;
                if (this.shield > 100)
                    this.shield = 100;
            }
        }




    }
}