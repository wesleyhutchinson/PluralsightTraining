using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private string title;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }


        /// <summary>
        /// Method to return employee data
        /// </summary>
        /// <returns></returns>

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Adam", Title = "Adamson" });
            employees.Add(new Employee() { Name = "Ben", Title = "Benson" });
            employees.Add(new Employee() { Name = "Charles", Title = "Charlson" });
            employees.Add(new Employee() { Name = "David", Title = "Davidson" });
            employees.Add(new Employee() { Name = "Edmond", Title = "Edmondson" });
            employees.Add(new Employee() { Name = "Frank", Title = "Frankson" });
            return employees;
        }

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
