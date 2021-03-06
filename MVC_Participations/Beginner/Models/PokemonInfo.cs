﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Beginner.Models
{
    public class PokemonInfo
    {
        public double height { get; set; }

        public string name { get; set; }

        [JsonProperty("sprites")]
        public Sprites squigglyWorm { get; set; }

        public double weight { get; set; }
    }
    public class Sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
