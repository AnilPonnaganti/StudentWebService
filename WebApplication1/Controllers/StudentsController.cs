using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MyNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetStudents()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Alice",
                    Age = 20,
                    Hobbies = new List<string> { "reading", "swimming", "coding" }
                },
                new Student
                {
                    Name = "Bob",
                    Age = 22,
                    Hobbies = new List<string> { "painting", "dancing", "singing" }
                }
            };

            return Ok(new { students });
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }
}
