using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace P_Pokemon
{
    public class PokemonInfoAPI
    {
        public double heigh { get; set; }
        public string name { get; set; }

        [JsonProperty("sprites")]
        public Sprites squigglyWorm { get; set; } //make a class bc curly brace
        public double weight { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
