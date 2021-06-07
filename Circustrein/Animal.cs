using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    class Animal 
    {
        public string name { get; set;}
        public int format { get; set; }
        public string  type{ get; set;}

        public bool isAdded { get; set; }
     

        
        
        public Animal(string animalName, int animalFormat, string animalType)
        {
            name = animalName;
            format = animalFormat;
            type = animalType;
        }
    }
}
