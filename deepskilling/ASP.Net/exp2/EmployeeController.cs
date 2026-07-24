using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
using WebAPIProject.Services;


namespace WebAPIProject.Controllers
{


    [Route("api/Emp")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {


        private readonly EmployeeService service;



        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }



        // GET API

        [HttpGet(Name="GetEmployees")]

        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<Employee>> Get()
        {

            return Ok(service.GetEmployees());

        }



        // POST API


        [HttpPost(Name="AddEmployee")]

        [ProducesResponseType(StatusCodes.Status200OK)]

        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult Post(Employee employee)
        {

            if(employee == null)
            {
                return BadRequest();
            }


            service.AddEmployee(employee);


            return Ok("Employee Added");

        }


    }

}