using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRPG_DIO.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero() { }
        public Hero(string Name, int level, string heroType)
        {
            this.Name = Name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            var patent = CheckPatent(this.Level);
            return $"Nome: {this.Name}/ Tipo Hero: {this.HeroType}/ Level: {this.Level}/ Patente: {patent}";
        }

        public virtual string Attack()
        {
            return string.Empty;
        }

        private Patent CheckPatent(int level)
        {
            Patent retorno;
            switch (level)
            {
                case < 40:
                    retorno = Patent.Bronze;
                    break;
                case < 80:
                    retorno = Patent.Prata;
                    break;
                default:
                    retorno = Patent.Ouro;
                    break;
            }
            
            return retorno;
        }
    }
}