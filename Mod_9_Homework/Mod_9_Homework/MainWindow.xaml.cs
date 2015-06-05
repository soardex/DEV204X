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

namespace Mod_9_Homework
{
    public class StudentInformation
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }

        public StudentInformation(String first, String last, String city)
        {
            FirstName = first;
            LastName = last;
            City = city;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<StudentInformation> mStudents;
        private int mIteratorIndex;

        public MainWindow()
        {
            InitializeComponent();
            Reset();

            mStudents = new List<StudentInformation>();
            mIteratorIndex = 0;
            btnNext.IsEnabled = false;
            btnPrevious.IsEnabled = false;
        }

        private void Reset()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            String first = txtFirstName.Text.ToString();
            String last = txtLastName.Text.ToString();
            String city = txtCity.Text.ToString();

            mStudents.Add(new StudentInformation(first, last, city));

            /// enable as we gonna do wrap the list
            if (!btnNext.IsEnabled) btnNext.IsEnabled = true;
            if (!btnPrevious.IsEnabled) btnPrevious.IsEnabled = true;

            Reset();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (mIteratorIndex < mStudents.Count)
            {
                StudentInformation temp = mStudents.ElementAt(mIteratorIndex);
                txtFirstName.Text = temp.FirstName.ToString();
                txtLastName.Text = temp.LastName.ToString();
                txtCity.Text = temp.City.ToString();

                mIteratorIndex++;
                if (mIteratorIndex >= mStudents.Count)
                {
                    mIteratorIndex = 0;
                }
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (mIteratorIndex > -1)
            {
                StudentInformation temp = mStudents.ElementAt(mIteratorIndex);
                txtFirstName.Text = temp.FirstName.ToString();
                txtLastName.Text = temp.LastName.ToString();
                txtCity.Text = temp.City.ToString();
                
                mIteratorIndex--;
                if (mIteratorIndex <= -1)
                {
                    mIteratorIndex = mStudents.Count - 1;
                }
            }
        }
    }
}
