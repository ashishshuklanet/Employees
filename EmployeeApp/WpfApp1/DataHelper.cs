using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Model;

namespace Employees
{
    public static class DataHelper
    {
        public static EmployeesList LoadEmployees()
        {
            using (StreamReader r = new StreamReader(Constants.JsonFilePath))
            {
                string json = r.ReadToEnd();
                var empList = JsonConvert.DeserializeObject<EmployeesList>(json);
                return empList;
            }
        }
    }
}
