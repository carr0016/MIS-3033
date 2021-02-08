using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFClassesExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, breed, url;

            name = txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("You must enter a name!");
                return;
            }
            breed = txtBreed.Text;
            url = txtURL.Text;

            Pet myPet = new Pet();
            {
                Breed = breed,
                Name = name,
                PicURL = url;
            };

            1stPets.Items.Add(myPet);



        }
    }
}
