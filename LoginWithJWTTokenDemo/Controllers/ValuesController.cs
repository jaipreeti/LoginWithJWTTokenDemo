using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithJWTTokenDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        static List<Student> gods = new List<Student>()
        {
            new Student{ Id=1, Name="Sri Ram" },
            new Student { Id = 2, Name = "Hanuman Ji" },
            new Student { Id = 3, Name = "Krishna Ji" }
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(gods);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            return Ok(gods.FirstOrDefault(x => x.Id == Id));
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
