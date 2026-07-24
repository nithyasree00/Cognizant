using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;


namespace WebAPIProject.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    [Authorize(Roles ="Admin")]
    public class EmployeeController : ControllerBase
    {


        private List<Employee> employees =
        new List<Employee>()
        {

            new Employee()
            {
                Id=1,
                Name="Nithya",
                Salary=50000
            },


            new Employee()
            {
                Id=2,
                Name="Rahul",
                Salary=40000
            }

        };




        [HttpGet]

        public ActionResult<List<Employee>> Get()
        {

            return Ok(employees);

        }


    }

}