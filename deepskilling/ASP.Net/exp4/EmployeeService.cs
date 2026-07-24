using WebAPIProject.Models;

namespace WebAPIProject.Services
{
    public class EmployeeService
    {

        private List<Employee> employees;


        public EmployeeService()
        {
            employees = new List<Employee>()
            {

                new Employee()
                {
                    Id=1,
                    Name="Nithya",
                    Salary=50000,
                    Permanent=true
                },


                new Employee()
                {
                    Id=2,
                    Name="Rahul",
                    Salary=40000,
                    Permanent=false
                },


                new Employee()
                {
                    Id=3,
                    Name="Anil",
                    Salary=30000,
                    Permanent=true
                }

            };
        }



        public List<Employee> GetEmployees()
        {
            return employees;
        }




        public Employee UpdateEmployee(Employee employee)
        {

            Employee existingEmployee =
                employees.Find(x => x.Id == employee.Id);


            if(existingEmployee == null)
            {
                return null;
            }



            existingEmployee.Name = employee.Name;

            existingEmployee.Salary = employee.Salary;

            existingEmployee.Permanent = employee.Permanent;



            return existingEmployee;

        }

    }
}