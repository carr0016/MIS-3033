using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_JSON_RickAndMorty
{
    public class RickAndMortyAPI
    {

        ///https://rickandmortyapi.com/api/character
        ///
        public Info info {get;set;}

        public List<Character> results { get; set; } //right of : and we have a square bracket which means any kind of collection we wanted. generated another class for character
         
    }

    public class Character
    {
        public int id { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public string image { get; set; }

        public override string ToString()
        {
            return $"{name} ({id})";
                
        }

    }

    public class Info //used lightbulb and clicked generate class
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }

    }
}
