using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class RandomNumberGenform : Form
    {
        public RandomNumberGenform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //Object creates random number
            int[] array = new int[100]; //This sets the size of the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100); //this for loop is used to set the range for the value of the random numbers
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]); //this for loop prints out the array so we can check the contents 
            }
        }
    }
}
