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

        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Aisle = "";
        }
        
        public string GetAisle()
        {
            //return Manufacturer.First().ToString().ToUpper();
            
            int pos;
            if (Aisle != "") return Aisle;

            string s;
            s = Manufacturer.Substring(0, 1).ToUpper();

            // Price with any not numeric character removed
            s += Price.ToString();
            while ((pos = s.IndexOf('$')) > -1)
                s = s.Remove(pos, 1);
            while ((pos = s.IndexOf(',')) > -1)
                s = s.Remove(pos, 1);
            while ((pos = s.IndexOf('.')) > -1)
                s = s.Remove(pos, 1);

            Aisle = s;
            return Aisle;

        }
        public string getAisle2()
        {
            // If the Aisle member has already been set, just return it
            if (Aisle != "") return Aisle;

            // Initiallize Aisle to a random number converted to string
            Random r = new Random();
            string s = r.Next().ToString();

            Aisle = s;
            return Aisle;
        }

        public override string ToString()
        {
            return $"{Manufacturer} - ({Name})";
        }


    }
}
