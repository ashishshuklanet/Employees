using NUnit.Framework;
using System.Collections.Generic;
using Employees;
using Employees.Model;
using Employees.ViewModel;

namespace EmployeeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoadFileData_Test()
        {
            //PREPARE
            EmployeesList empList;

            //ACT
            empList = DataHelper.LoadEmployees();

            //ASSERT
            Assert.IsTrue(empList.Employees.Count > 0);
        }

        [Test]
        public void EmployeesViewModel_Test()
        {
            //PREPARE
            EmployeesViewModel empVM = new EmployeesViewModel(false);
            //ACT
            empVM.LoadData(true);

            //ASSERT
            Assert.IsTrue(empVM.Employees.Count > 0);
        }
    }
}