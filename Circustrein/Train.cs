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

        List<Train> trainlist = new List<Train>();
       public List<Wagon> wagonlist = new List<Wagon>();
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

        //public void CheckList()
        //{
            //foreach (var item in Animalslist)
            //{
            //    orderCarnivores(item);

            //    // form smallest to largest
            //    switch (item.format)
            //    {
            //        case 1:
            //            orderHerbivores(1);
            //            break;
            //        case 3:
            //            orderHerbivores(3);
            //            break;
            //        case 5:
            //            orderHerbivores(5);
            //            break;

            //    }
            //}
            
        //}
        // 2 bool functions, 1 animalnoteaten en 1 checkiffits
        //public bool orderCarnivores(Animal item)
        //{
        //    //of we in waggon passen

        //    //kan een grotere herbivore in een wagon passen 
        //    foreach (var animal in Animalslist)
        //    {
        //        if (animal.type == "Carnivore" && animal.isAdded == false )
        //        {
        //            foreach (var wagon in wagonlist)
        //            {
                        
        //                //Carnivore mag met geen een andere
        //                //de checks of die in een wagon past
        //                //herbivore die groter is mag wel in een wagon 
        //                //Past de carnivore wel:
        //                if (wagon.CarnivorePresent == false)
        //                {
        //                    wagon.maxSize = wagon.maxSize - animal.format;
        //                   // MessageBox.Show("New animal added to wagon" + wagon.maxSize);
        //                    if (animal.format == 5)
        //                    {
        //                        wagon.BigCarnivorePresent = true;
        //                    }
        //                    wagon.maxSize = wagon.maxSize - animal.format;

        //                    wagon.CarnivorePresent = true;
        //                    wagon.AddToWagon(animal.name, animal.format, animal.type );
        //                    animal.isAdded = true;
                            
        //                }
        //            }
        //            //past ie niet of bestaat nog geen wagon:
        //            if (animal.isAdded == false)
        //            {
        //               // MessageBox.Show("new wagon created");

        //                if (wagonlist.Count > 0)
        //                {
        //                    var specific = wagonlist[wagonlist.Count - 1];
        //                    specific.CarnivorePresent = true;
        //                    specific.maxSize = specific.maxSize - animal.format;

        //                }
        //                animal.isAdded = true;
                       
        //            }

        //        }

                
        //    }
        //    return true;

        //}
        //public bool orderHerbivores(int size)
        //{
        //    foreach (var animal in Animalslist)
        //    {
        //        if (animal.type == "Herbivore" && animal.isAdded == false)
        //        {
        //            foreach (var wagon in wagonlist)
        //            {
        //                //Als een grote carnivore in een wagon is, mag niemand meer erin
        //                //Grote herbivore mag bij een kleinere carnivore
        //                //de if stattement hieronder is puur voor de grootste herbivore, die kan nml erbij als de carnivore maat 3 of 1 is.
        //                if (wagon.CarnivorePresent == true && wagon.BigCarnivorePresent == false && animal.format == 5)
        //                {
        //                    wagon.maxSize = wagon.maxSize - animal.format;
        //                   // MessageBox.Show("New  Herbivore animal added to wagon" + wagon.maxSize);
        //                    wagon.AddToWagon(animal.name, animal.format, animal.type);
        //                    animal.isAdded = true;  
        //                }
        //                // add herbivore
        //                if (wagon.CarnivorePresent == false)
        //                {
        //                    wagon.maxSize = wagon.maxSize - animal.format;
        //                   // MessageBox.Show("New  Herbivore animal added to wagon" + wagon.maxSize);
        //                    wagon.AddToWagon(animal.name, animal.format, animal.type);
        //                    animal.isAdded = true;
                            
        //                }

        //            }
        //            //past ie niet of bestaat nog geen wagon:
        //            if (animal.isAdded == false)
        //            {
        //               // MessageBox.Show("new wagon created");

        //                if (wagonlist.Count > 0)
        //                {
        //                    var specific = wagonlist[wagonlist.Count - 1];
        //                    specific.maxSize = specific.maxSize - animal.format;

        //                }
        //                animal.isAdded = true;
                        
        //            }
        //        }

        //    }
        //    return true;
        //}

        public bool CheckIfFits(List<Animal> animalsList, bool HERB)
        {
            return true;
        }
        public bool addToWagon(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                foreach (var wagon in wagonlist)
                {
                    if (wagon.AddToWagon(animal) == true)
                    {
                        return true;
                    }
                }
                if (animal.isAdded == false)
                {
                    Wagon wagon = new Wagon();
                    wagon.AddToWagon(animal);
                    wagonlist.Add(wagon);
                }
            }
           
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
        public List<Wagon> returnlist()
        {
            return wagonlist;
        }
        public List<Animal> returnAnimalList()
        {
            return Animalslist;
        }
        public void clearList()
        {
            foreach (var animal in Animalslist)
            {
                animal.isAdded = false;
            }
            
            wagonlist.Clear();
            
        }



    }
}
