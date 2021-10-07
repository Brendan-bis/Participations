using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon
{
    public class PokemonAPI
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokemonResultsAPI> results { get; set; }


    }
    public class PokemonResultsAPI
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
