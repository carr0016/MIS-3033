using System;
using System.Collections.Generic;
using System.Text;

namespace WPFClasses
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        //private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;

            Price = 0;
            //Aisle = "";
        }
        
        //public string GetAisle()
        //{
            ///return Manufacturer.First().ToString().ToUpper();
        //}
        
        public override string ToString()
        {
            return $"{Manufacturer} - ({Name})";
        }


    }
}
