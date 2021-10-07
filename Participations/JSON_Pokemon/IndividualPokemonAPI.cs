using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    public class IndividualPokemonAPI
    {
        public string height { get; set; }
        public string weight { get; set; }
        public SpritesAPI sprites { get; set; }
    }
    public class SpritesAPI
    {
        public string back_default { get; set; }
        public string front_default { get; set; }

    }
}
