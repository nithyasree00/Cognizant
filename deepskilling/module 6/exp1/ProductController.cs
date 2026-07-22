using Microsoft.AspNetCore.Mvc;
using WebAPIProject.Models;
using WebAPIProject.Services;


namespace WebAPIProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {

        private readonly ProductService service;


        public ProductController(ProductService service)
        {
            this.service = service;
        }



        // HTTP GET

        [HttpGet]

        public ActionResult<List<Product>> Get()
        {
            return Ok(service.GetProducts());
        }



        // HTTP GET BY ID

        [HttpGet("{id}")]

        public ActionResult<Product> Get(int id)
        {

            Product product = service.GetProductById(id);


            if(product == null)
            {
                return NotFound();
            }


            return Ok(product);

        }




        // HTTP POST

        [HttpPost]

        public ActionResult Add(Product product)
        {

            service.AddProduct(product);


            return Ok("Product Added Successfully");

        }





        // HTTP DELETE

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {

            service.DeleteProduct(id);


            return Ok("Product Deleted");

        }




        // HTTP PUT

        [HttpPut("{id}")]

        public ActionResult Update(int id, Product product)
        {

            if(id <= 0)
            {
                return BadRequest();
            }


            return Ok("Product Updated");

        }

    }
}