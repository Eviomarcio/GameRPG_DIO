using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRPG_DIO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return $"{Name} Lançou Mágia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{Name} Lançou Mágia super efetiva com bônus de ataque de {bonus}";
            }
            else
            {
                return $"{Name} Lançou Mágia fraca, com bônus de {bonus}";
            }
        }
    }
}