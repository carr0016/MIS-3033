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

namespace WPFParticipation1
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

        private void btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateOfBirth;
            DateTime.TryParse(txtDOB.Text, out dateOfBirth);
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = currentDate.Subtract(dateOfBirth);
            DateTime age = DateTime.MinValue + difference;
            int ageInYears = age.Year - 1;
            txtage.Text = (ageInYears).ToString();

            
        }

        private void calculatebutton_MouseEnter(object sender, MouseEventArgs e)
        {
            calculatebutton.Background = Color.Blue;
        }
    }

    }

