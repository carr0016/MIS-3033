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

namespace PracticeHW_GraduationHandout
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool isEverythingGood = true;

            if (string.IsNullOrWhiteSpace(txtCity.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid city");
            }
            if (string.IsNullOrWhiteSpace(txtFName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid First Name");
            }

            double gpa;
            if (double.TryParse(txtGPA.Text, out gpa) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid GPA");
            }
            if (string.IsNullOrWhiteSpace(txtLName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Last Name");
            }
            if (string.IsNullOrWhiteSpace(txtMajor.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Major");
            }
            if (string.IsNullOrWhiteSpace(txtState.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid State");
            }
            if (string.IsNullOrWhiteSpace(txtStreetName.Text) == true)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Street Name");
            }
            int streetNumber, zipcode;

            if (int.TryParse(txtStreetNum.Text, out streetNumber) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid Street Number");
            }

            if (int.TryParse(txtZipcode.Text, out zipcode) == false)
            {
                isEverythingGood = false;
                MessageBox.Show("You must enter a valid zipcode");
            }
            if (isEverythingGood == false)
            {
                return;
            }

            Student student = new Student()
            {
                FirstName = txtFName.Text,
                GPA = gpa,
                LastName = txtLName.Text,
                Major = txtMajor.Text,
            };

            student.SetAddress(streetNumber, txtStreetName.Text, txtState.Text, txtCity.Text, zipcode);
            lstGraduationHandout.Items.Add(student);
            txtFName.Clear();
            txtLName.Clear();
            txtMajor.Clear();
            txtCity.Clear();
            txtGPA.Clear();
            txtState.Clear();
            txtStreetName.Clear();
            txtStreetNum.Clear();
            txtZipcode.Clear();
        }

        

    }
}
