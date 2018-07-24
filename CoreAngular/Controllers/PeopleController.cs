using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAngular.AdventureWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreAngular.AdventureWorks.SqliteModel;
using CoreAngular.Model;
#pragma warning disable 1591

namespace CoreAngular.Controllers
{
    [Route("api/[controller]"), Produces("application/json")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly Adventureworks2017Context _context;

        public PeopleController(Adventureworks2017Context context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        public IEnumerable<Person> GetPerson()
        {
            return _context.Person;
        }

        [HttpGet("GetEmployeeViewModel")]
        public IEnumerable<EmployeeViewModel> EmployeeViewModel()
        {
            var list = _context.Person.Where(p => p.PersonType == "EM").Include(p => p.Employee)
                .Select(p => new EmployeeViewModel
                {
                    BusinessEntityId = p.BusinessEntityId,
                    LoginId = p.Employee.LoginId,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    EmailAddress = p.EmailAddress.AsQueryable().Select(e => e.EmailAddress1).FirstOrDefault() 
                });
            return list;
        }

        [HttpGet("GetCustomerViewModel")]
        public IEnumerable<CustomerViewModel> CustomerViewModel()
        {
            var list = _context.Person.Where(p => p.PersonType == "SC").Select(p =>
                new CustomerViewModel
                {
                    BusinessEntityId = p.BusinessEntityId,
                    Title = p.Title,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    EmailAddress = p.EmailAddress.AsQueryable().Select(e => e.EmailAddress1).FirstOrDefault(),
                });
            return list;
        }

        [HttpGet("GetEmployeeDetail/{id}")]
        public async Task<IActionResult> GetEmployeeDetail([FromRoute] long id)
        {
            var detail = await GetPersonDetail(id);
            return Ok(detail);
        }

        [HttpPost("Validate")]
        public async Task<IActionResult> ValidatePerson([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await Task.Delay(1000);

            var person = await _context.Person.Include(p => p.Employee).Include(p => p.Password)
                .FirstOrDefaultAsync(p => p.Employee != null && p.Employee.LoginId == user.LoginId);
 
            if (person == null)
            {
                return NotFound();
            }

            var encriptedPassword = SecurityService.GenerateHashedPassword(person.Password.PasswordSalt, user.Password);

            if (encriptedPassword != person.Password.PasswordHash)
            {
                return BadRequest(new {message = "password is not correct"});
            }
            var detail = await GetPersonDetail(person.BusinessEntityId);
            return Ok(detail);
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = await _context.Person.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson([FromRoute] long id, [FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != person.BusinessEntityId)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/People
        [HttpPost]
        public async Task<IActionResult> PostPerson([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Person.Add(person);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonExists(person.BusinessEntityId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPerson", new { id = person.BusinessEntityId }, person);
        }

        // DELETE: api/People/5

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return Ok(person);
        }

        private async Task<Person> GetPersonDetail(long id)
        {
            var detail = Task.Factory.StartNew(() => _context.Person.Include(p => p.Employee)
                .Include(p => p.EmailAddress).FirstOrDefault(p => p.BusinessEntityId == id));
            await detail;
            // to cut off looping references for json serialization.
            var first = detail.Result.EmailAddress.FirstOrDefault();
            if (first != null) first.BusinessEntity = null;
            detail.Result.Employee.BusinessEntity = null;
            return detail.Result;
        }

        private bool PersonExists(long id)
        {
            return _context.Person.Any(e => e.BusinessEntityId == id);
        }
    }
}