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

namespace WPFClasses
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
            string manufacturer, name;

            manufacturer = txtMan.Text;
            name = txtName.Text;

            Toy myToy = new Toy();
            {
                myToy.Manufacturer = manufacturer;
                myToy.Name = name;       
            }

            lstToys.Items.Add(myToy);
            //Toy selectedToy = (Toy)lstToys.SelectedItem;


        }
    }
}
