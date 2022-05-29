using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRPG_DIO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou com sua shuriken.";
        }

        public virtual string Attack(int bonus)
        {
            return $"{this.Name} Atacou com sua shuriken e uma bônus de {bonus} em ninjutsu.";
        }
    }
}