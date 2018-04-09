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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee employee;

        public MainWindow()
        {
            InitializeComponent();
            employee = new Employee()
            {
                Name = "Joe",
                Title = "QA"
            };
            DataContext = employee;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = "Bob";
            employee.Title = "Evangelist";
        }
    }
}
