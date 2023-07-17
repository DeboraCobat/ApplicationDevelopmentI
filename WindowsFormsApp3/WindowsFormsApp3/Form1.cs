using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int diceRoll = random.Next(1, 7);
            string imageName = $"dice{diceRoll}";
            resultPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dicePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void resultPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}