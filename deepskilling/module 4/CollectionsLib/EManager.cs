using System.Collections.Generic;

namespace CollectionsLib
{
    public class EmployeeManager
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id=100,Name="Nithya"},
                new Employee{Id=101,Name="Rahul"},
                new Employee{Id=102,Name="Anil"}
            };
        }

        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return new List<Employee>()
            {
                new Employee{Id=100,Name="Nithya"},
                new Employee{Id=101,Name="Rahul"},
                new Employee{Id=102,Name="Anil"}
            };
        }
    }
}