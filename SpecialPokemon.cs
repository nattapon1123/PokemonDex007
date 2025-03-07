using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Special : Pokemon
    {
        // Constructor
        public Special() : base("Special", 120, 120, 120, 120, "Original Pokémon", PokemonType.Normal, @"Images\arceus.jpg")
        {
        }
    }
}
