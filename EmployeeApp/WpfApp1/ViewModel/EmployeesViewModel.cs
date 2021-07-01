using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Employees.Model;

namespace Employees.ViewModel
{
    public class EmployeesViewModel
    {

        public ObservableCollection<Employee> Employees { get; set; }

        public ICommand LoadCommand
        {
            get;
            set;
        }

        public bool IsDataLoaded
        {
            get;
            set;
        }

        public EmployeesViewModel() : this(true)
        {

        }
        public EmployeesViewModel(bool loadData = true)
        {
            Predicate<object> canExecute = _ => !IsDataLoaded;
            LoadCommand = new MainCommand((IsDataLoaded) => LoadData(loadData), canExecute);
            Employees = new ObservableCollection<Employee>();
        }

        public void LoadData(bool load)
        {
            if (load)
            {
                Employees.Clear();
                DataHelper.LoadEmployees()?.Employees.ToList().ForEach(ele => Employees.Add(ele));
            }
            if (Employees?.Count > 0)
                IsDataLoaded = true;


        }

    }


}
