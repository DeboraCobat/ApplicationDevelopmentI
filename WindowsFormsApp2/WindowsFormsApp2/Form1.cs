using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\IO\MyFile.txt"; // Path to the file

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                richTextBox1.Text = text;
                textBox1.Text = filePath;

            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string word = textBox2.Text;
            string text = richTextBox1.Text;
            int count = 0;

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(text))
            {
                string[] words = Regex.Split(text, @"\W+"); // Split text into words using regular expressions
                foreach (string w in words)
                {
                    if (w.ToLower() == word.ToLower())
                    {
                        count++;
                    }
                }
            }

            label1.Text = "The word appeared: " + count.ToString();
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;

            File.WriteAllText(filePath, text);

            MessageBox.Show("File written successfully!");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                string text = File.ReadAllText(filePath);
                richTextBox1.Text = text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
