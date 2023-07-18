using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            int diceRoll = random.Next(1, 7);
            string imageName = $"dice{diceRoll}.png";
            string imagePath = $"/Images/{imageName}";

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(imagePath, UriKind.Relative);
            image.EndInit();

            resultImage.Source = image;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
