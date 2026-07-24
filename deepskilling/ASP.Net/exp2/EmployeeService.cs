using WebAPIProject.Models;


namespace WebAPIProject.Services
{

    public class EmployeeService
    {

        private List<Employee> employees =
            new List<Employee>()
            {

                new Employee()
                {
                    Id = 1,
                    Name="Nithya",
                    Department="CSE"
                },


                new Employee()
                {
                    Id = 2,
                    Name="Rahul",
                    Department="HR"
                }

            };



        public List<Employee> GetEmployees()
        {
            return employees;
        }


        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

    }

}
