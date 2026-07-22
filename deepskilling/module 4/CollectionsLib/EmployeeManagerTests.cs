using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using CollectionsLib;

namespace CollectionsLib.Tests
{
    [TestFixture]
    public class EmployeeManagerTests
    {
        private EmployeeManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new EmployeeManager();
        }

        // Scenario 1
        [Test]
        public void GetEmployees_NoNullValues_ReturnsTrue()
        {
            List<Employee> employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreNotNull(employees);
        }

        // Scenario 2
        [Test]
        public void GetEmployees_EmployeeId100Exists_ReturnsTrue()
        {
            List<Employee> employees = manager.GetEmployees();

            bool found = employees.Any(e => e.Id == 100);

            Assert.That(found, Is.True);
        }

        // Scenario 3
        [Test]
        public void GetEmployees_AllEmployeesUnique_ReturnsTrue()
        {
            List<Employee> employees = manager.GetEmployees();

            CollectionAssert.AllItemsAreUnique(employees);
        }

        // Scenario 4
        [Test]
        public void EmployeeCollections_AreEqual_ReturnsTrue()
        {
            List<Employee> list1 = manager.GetEmployees();

            List<Employee> list2 = manager.GetEmployeesWhoJoinedInPreviousYears();

            CollectionAssert.AreEqual(list1, list2);
        }

        // Constraint Model
        [Test]
        public void EmployeeCollections_ConstraintModel_ReturnsTrue()
        {
            List<Employee> list1 = manager.GetEmployees();

            List<Employee> list2 = manager.GetEmployeesWhoJoinedInPreviousYears();

            Assert.That(list1, Is.EqualTo(list2));
        }
    }
}