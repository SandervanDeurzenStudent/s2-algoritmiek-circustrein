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
        List<Animal> animalsList = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            //animal format to int
            int animal_format = Convert.ToInt32(cb_format.Text);

            Animal animal = new Animal(textBox1.Text, animal_format, cb_animalType.Text);
            animalsList.Add(animal);
            lb_added_desc.Items.Add(textBox1.Text + animal_format.ToString() + cb_animalType.Text);
        }
        private void cb_format_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //clear al the wagons  before ordering
            train.clearList();

            //clear the listbox
            lb_wagon_desc.Items.Clear();

            train.addToWagon(animalsList);

            foreach (var item in train.wagonlist)
            {
                lb_wagon_desc.Items.Add(item);
            }
        }
    }
}
