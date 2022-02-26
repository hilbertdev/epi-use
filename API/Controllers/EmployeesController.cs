using System.Threading.Tasks;
using Application.Employees.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesQuery query;

        public EmployeesController(EmployeesQuery query)
        {
            this.query = query;
        }
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
           return this.Ok(await this.query.GetEmployeesAsync().ConfigureAwait(false));
        }

        [HttpGet("GetEmployeeByEmployeeNumber")]
        public async Task<IActionResult> GetEmployeeByEmployeeNumber(int employeeNumber)
        {
           return this.Ok(await this.query.GetEmployeeByEmployeeNumberAsync(employeeNumber).ConfigureAwait(false));
        }

        [HttpGet("OrganisationalStructure")]
        public async Task<IActionResult> GetOrganisationalStructure()
        {
            return this.Ok(await this.query.GetOrganisationalStructureAsync().ConfigureAwait(false));
        }
    }
}