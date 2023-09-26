using Entities;
using Microsoft.AspNetCore.Mvc;

namespace MaterializationInterceptor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly EmployeeDbContext _employeeDbContext;
        private readonly IRepository repository;
        public WeatherForecastController(EmployeeDbContext employeeDbContext, IRepository repository)
        {
            _employeeDbContext = employeeDbContext;
            this.repository = repository;
        }



        [HttpGet(Name = "Employee")]
        public IActionResult Employee()
        {
            var employee = _employeeDbContext.Employee.First();
            employee.Test();

            return Ok();
        }
    }
}