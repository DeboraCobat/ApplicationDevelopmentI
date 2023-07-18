using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        private string filePath = @"C:\IO\MyFile.txt"; // Path to the file

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                richTextBox1.AppendText(text);
                textBox1.Text = filePath;
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            string word = textBox2.Text;
            string text = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;
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

            label1.Content = "The word appeared: " + count.ToString();
        }

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd).Text;

            File.WriteAllText(filePath, text);
            MessageBox.Show("File written successfully!");
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                string text = File.ReadAllText(filePath);
                richTextBox1.AppendText(text);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
