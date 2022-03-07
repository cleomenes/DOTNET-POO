using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet___POO.src.Entities
{
    public abstract class Hero
    {
        public string? Name;
        public int Level;
        public en_tipoHero TipoHero;

        public Hero(string _name, int _level, en_tipoHero _tipoHero)
        {
            Name = _name;
            Level = _level;
            TipoHero = _tipoHero;
        }
        public Hero (){}

        public override string ToString()
        {
            return "Heroi: " + this.Name + " Level: " + this.Level + " Classe: " + TipoHero;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou"; 
        }
    }
}