using Employee_1031API.Data;
using Employee_1031API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_1031API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // Varun Kapoor
        [HttpGet]
        public IActionResult GetALL() 
        { 
            return Ok (_context.employees.ToList());
        }
        [HttpPost]
        public IActionResult saveEmployee([FromBody]Employee employee)
        {
            if (employee == null) return NotFound();
            if(!ModelState.IsValid) return BadRequest(ModelState);
            _context.employees.Add(employee);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateEmployee( [FromBody]Employee employee)
        {
            if(employee == null) return NotFound();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _context.employees.Update(employee);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Deleteemployee(int id)
        {
            var employee = _context.employees.Find(id);
            if(employee == null) return NotFound();
            _context.employees.Remove(employee);
            _context.SaveChanges();
            return Ok();
        }
    }
}
