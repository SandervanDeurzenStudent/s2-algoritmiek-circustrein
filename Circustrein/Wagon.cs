using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        public int maxSize { get; set; } = 10;
        public string wagonType { get; set; }

        public bool BigCarnivorePresent { get; set; } = false;

        public bool CarnivorePresent { get; set; }

        List<Animal> Animalslist = new List<Animal>();

        
        public void AddToWagon(string animalName, int animalFormat, string animalType)
        {
            Animalslist.Add(new Animal(animalName, animalFormat, animalType));
        }

        public bool AddToWagon(Animal animal)
        {
            if (CheckSize(animal) == true && CheckType(animal) && true)
            {
                maxSize = maxSize - animal.format;
                // MessageBox.Show("New  Herbivore animal added to wagon" + wagon.maxSize);
                AddToWagon(animal.name, animal.format, animal.type);

                animal.isAdded = true;
                return true;
            }
            return false;
        }

        public bool CheckSize(Animal animal)
        {
            if (maxSize - animal.format >= 0)
            {
                return true;
            }

            return false;
        }
        public bool CheckType(Animal animal)
        {
            foreach (var animalInList in Animalslist)
            {
                if (animalInList.format <= animal.format && animal.type == "Carnivore" || animalInList.format >= animal.format && animalInList.type == "Carnivore")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;

        }

        public override string ToString()
        {
            return $"MaxSize = {maxSize} aantal animals = {Animalslist.Count}";
        }
    }
}
