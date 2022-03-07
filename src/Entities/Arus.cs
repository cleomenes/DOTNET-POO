using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet___POO.src.Entities
{
    public class Aros
    {
        public string Name { get; set; }
        public int Level;
        public en_tipoHero TipoHero;

        public Arus(string _name, int _level, en_tipoHero _tipoHero)
        {
            Name = _name;
            Level = _level;
            TipoHero = _tipoHero;
        }
    }
}