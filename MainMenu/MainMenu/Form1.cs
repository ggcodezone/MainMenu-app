using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Application Hub (Main Menu)
//Author: Gwen Kalasky
//Synopsis:this main menu can be used to access all of the other form apps by clicking the corresponding button
//Date: 10/20/2020

namespace MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerLaunch_Click(object sender, EventArgs e)
        {
            MainMenu.Timerform form = new MainMenu.Timerform();
            form.ShowDialog();
        }

        private void Queuelaunch_Click(object sender, EventArgs e)
        {
            MainMenu.Queueform form = new MainMenu.Queueform();
            form.ShowDialog();
        }

        private void LinkedlistLaunch_Click(object sender, EventArgs e)
        {
            MainMenu.LinkedListform form = new MainMenu.LinkedListform();
            form.ShowDialog();
        }

        private void Stacklaunch_Click(object sender, EventArgs e)
        {
            MainMenu.Stackform form = new MainMenu.Stackform();
            form.ShowDialog();
        }

        private void RandomNumberLaunch_Click(object sender, EventArgs e)
        {
            MainMenu.RandomNumberGenform form = new MainMenu.RandomNumberGenform();
            form.ShowDialog();
        }
    }
}
