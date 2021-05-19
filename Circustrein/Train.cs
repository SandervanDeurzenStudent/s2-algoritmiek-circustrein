using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    class Train
    {

        public int maxSize = 10;
        List<Train> trainlist = new List<Train>();
        List<Wagon> wagonlist = new List<Wagon>();
        List<Animal> Animalslist = new List<Animal>();

        public void addToListbox(List<Animal> ListOfAnimals, ListBox lb)
        {
            foreach (var animal in ListOfAnimals)
            {
                lb.Items.Add("Animal " + animal.name + " with type " + animal.type);
            }
           
            //Animalslist.Add(animalName, test);
            // eerst checken of het een carnivor/herbivore is.
            //kijken of ze in een waggon past
        }

        public void CheckList(List<Animal> animalsList, ListBox lb_wagon)
        {
            foreach (var item in animalsList)
            {
                AnimalNotEaten(item);
                //if (item.type == "Herbivore")
                //{
                //    dinotype = "herbivore";
                //    AnimalNotEaten(animalsList);
                //}
                //else
                //{
                //    dinotype = "carnivore";
                //    AnimalNotEaten(animalsList, dinotype);
                //}
                //if (item.type == "Carnivore")
                //{
                //    lb_wagon.Items.Add("Wagon 1: amount " + Remaining);
                //}


               
                //switch (item.format)
                //{
                //    case 1:
                //        wagon.maxSize = wagon.maxSize - 1;
                //        lb_wagon.Items.Add("Wagon 1: amount" + wagon.maxSize);
                //        break;
                //    case 3:
                //        wagon.maxSize = wagon.maxSize - 3;
                //        lb_wagon.Items.Add("Wagon 1: amount " + wagon.maxSize);
                //        break;
                //    case 5:
                //        wagon.maxSize = wagon.maxSize - 5;
                //        lb_wagon.Items.Add("Wagon 1: amount " + wagon.maxSize);
                //        break;
                //}
            
            }
            
        }
        // 2 bool functions, 1 animalnoteaten en 1 checkiffits
        public bool AnimalNotEaten(Animal item)
        {
            //of we in waggon passen
            //                          Carnivore mag met geen een andere
            //kan een grotere herbivore in een wagon passen 
            foreach (var animal in Animalslist)
            {
                if (animal.type == "Carnivore" && animal.isAdded == false)
                {
                    foreach (var wagon in wagonlist)
                    {
                        //de checks of die in een wagon past
                        //past ie wel:
                        if (wagon.CarnivorePresent == false)
                        {
                            wagon.AddToWagon(animal.name, animal.format, animal.type );
                            animal.isAdded = true;
                            break;
                        }
                    }
                    //past ie niet:
                    if(animal.isAdded == false)
                    {
                        wagonlist.Add(new Wagon(animal.name, animal.format, animal.type));
                        animal.isAdded = true;
                    }
                }

            }
            return true;
        }

        public bool CheckIfFits(List<Animal> animalsList, bool HERB)
        {
            return true;
        }

        public void Herbivore(List<Animal> herbivores)
        {

        }

        public void Carnivore(List<Animal> carnivores)
        {

        }
        public void addAnimal(string animalName, int animalFormat, string animalType)
        {
             Animalslist.Add(new Animal(animalName, animalFormat, animalType));
           
        }



    }
}
