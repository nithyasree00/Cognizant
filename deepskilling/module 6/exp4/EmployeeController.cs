using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
using WebAPIProject.Services;


namespace WebAPIProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {


        private readonly EmployeeService service;



        public EmployeeController(EmployeeService service)
        {
            this.service = service;
        }





        // PUT UPDATE EMPLOYEE

        [HttpPut]


        public ActionResult<Employee> Put(
            [FromBody] Employee employee)
        {


            // Check id value

            if(employee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }




            Employee updatedEmployee =
                service.UpdateEmployee(employee);




            // Employee id not available

            if(updatedEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }




            return Ok(updatedEmployee);

        }

    }

}