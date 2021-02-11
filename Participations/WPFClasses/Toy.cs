using System;
using System.Collections.Generic;
using System.Text;

namespace WPFClasses
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        ///public double Price { get; set; }

        ///private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            ///Price = double.Empty;

        }
        ///public string GetAisle()

        public override string ToString()
        {
            return $"{Manufacturer} - ({Name})";
        }


    }
}
