using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet___POO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string _name, int _level, en_tipoHero _tipoHero)
        {
            Name = _name;
            Level = _level;
            TipoHero = _tipoHero;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua espada"; 
        }
    }
}