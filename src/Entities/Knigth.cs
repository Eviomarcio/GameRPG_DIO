using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRPG_DIO.src.Entities
{
    public class Knigth : Hero
    {
        public Knigth(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string Attack()
        {
            return $"{this.Name} Atacou com sua espada.";
        }
    }
}