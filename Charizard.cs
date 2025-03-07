using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Charizard : Pokemon
    {
        // Constructor
        public Charizard() : base("Charizard", 78, 84, 78, 100, "Flame Pokémon", PokemonType.Fire, @"Images\charizard.jpg")
        {
        }
    }
}

