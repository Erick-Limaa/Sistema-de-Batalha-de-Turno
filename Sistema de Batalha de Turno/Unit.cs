using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sistema_de_Batalha_de_Turno
{
    internal class Unit
    {
        private int currentHP;
        private int maxHP;
        private int attack;
        private int healPower;
        private string Unitname;
        private Random random;

        public int HP { get { return currentHP; } }
        public String UnitName { get { return Unitname; } }

        public bool isDead { get { return currentHP <= 0; } }

        public Unit(int maxHP, int attack, int heal, String Unitname)
        {
            this.maxHP = maxHP;
            this.currentHP = maxHP;
            this.attack = attack;
            this.healPower = heal;
            this.Unitname = Unitname;
            this.random = new Random();
        }

        public void Attack(Unit userToAttack)
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int randDamage = (int)(attack * rng);
            userToAttack.Takendamage(randDamage);
            Console.WriteLine(Unitname + " ataca " + userToAttack.Unitname + " e causa " + randDamage + " de dano!");
        }

        public void Takendamage(int damage)
        {
            currentHP -= damage;

            if(isDead)
                Console.WriteLine(UnitName + " foi derrotado!");
        }

        public void Heal()
        {
            double rng = random.NextDouble();
            rng = rng / 2 + 0.75f;
            int heal = (int)(rng * healPower);
            currentHP = heal = currentHP > maxHP ? maxHP : currentHP + heal;
            Console.WriteLine(UnitName + " cura " + heal);
        }
    }
}
