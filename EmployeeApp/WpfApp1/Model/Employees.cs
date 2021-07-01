using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Employees.Model
{
    /// <summary>
    /// Main Employee class which defines the attributes of an employee
    /// </summary>
    public class Employee
    {
        [JsonProperty("EmployeeName")]
        public string Name   { get; set; }
        [JsonProperty("EmployeeId")]
        public long Id { get; set; }
        [JsonProperty("Department")]
        public string Department { get; set; }
        [JsonProperty("Salary")]
        public decimal Salary { get; set; }

        public bool IsSalaryGreaterThanBaseSalary
        {
            get
            {
                if (Salary > Constants.BaseSalary)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsBaseDepartment
        {
            get
            {
                if (Department == Constants.BaseDepartment)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Determine which Category employee is in
        /// </summary>
        public enum Category
        {
            Salary,
            Department
        }
    }

   /// <summary>
   /// Load File Data
   /// </summary>
    public class EmployeesList
    {
        public ObservableCollection<Employee> Employees { get; set; }
    }

}
