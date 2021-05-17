using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {

        Train train = new Train();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            //animal format to int
            int animal_format = Convert.ToInt32(cb_format.Text);

            //send to animalclass
           // Animal animal = new Animal(textBox1.Text, animal_format, cb_animalType.Text);

            //List<Animal> listOfAnimals =  animal.addToList(animal);
            
           
            //send to Train class
           
            train.addAnimal(textBox1.Text, animal_format, cb_animalType.Text);
            
            //train.addToListbox(listOfAnimals, lb_added_desc);

            //foreach (var animal in listOfAnimals)
            //{
            //    lb.Items.Add("Animal " + animal.name + " with type " + animal.type);
            //}



        }
        private void cb_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
