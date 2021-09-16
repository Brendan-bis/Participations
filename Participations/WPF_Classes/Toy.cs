using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_Classes
{
    public class Toy
    {
        public string Manufacturer {get;set;}
        public string Name {get;set;}
        public double Price {get;set;}
        public string Image {get;set;}
        private string Aisle;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Image = string.Empty;
        }

        public string GetAisle()
        {
            //Returns the first letter of the Manufacturer, capitalized with the value of the Price afterwards (with no punctuation like . or , or $).
            string firstLetter = Manufacturer[0].ToString() + Price.ToString().Replace(".","");
            
            return firstLetter;
        }
        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
