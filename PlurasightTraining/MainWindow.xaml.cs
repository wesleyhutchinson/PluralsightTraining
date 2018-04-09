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

namespace PlurasightTraining
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

        /// <summary>
        /// Event from save button click - save details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full Name: ");
            sb.Append(FullName.Text);
            sb.Append("\nAge: ");
            sb.Append(Age.Text);
            sb.Append("\nSex: ");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            sb.Append("\nComputer: ");
            sb.Append((bool)Desktop.IsChecked ? "Desktop " : "");
            sb.Append((bool)Laptop.IsChecked ? "Laptop " : "");
            sb.Append((bool)Tablet.IsChecked ? "Tablet " : "");
            sb.Append("\nOccupation: ");
            sb.Append(Occupation.SelectedItem.ToString());
            sb.Append("\nDelivery Date: ");
            sb.Append(DeliveryDate.SelectedDate.ToString());

            MessageBox.Show(sb.ToString());
        }

        private void Occupation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlySelectedItems = e.AddedItems[0];
            MessageBox.Show(newlySelectedItems.ToString());
        }
    }
}
