using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FluentValidationTestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationtestController : ControllerBase
    {
        // GET: api/<ValidationtestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // POST api/<ValidationtestController>
        [HttpPost]
        public IActionResult TestValidation( string email, string name, int age)
        {
            var person = new Person(name, age, email);

            var validator= new PersonValidator();
            var result= validator.Validate(person);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                    return Ok(error.ErrorMessage);
                }
            }
            Console.WriteLine("Finished");
            Console.WriteLine();
            return Ok("Finished");




        }


    }
}
