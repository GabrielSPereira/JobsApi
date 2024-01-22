using JobsApi.Entities;
using JobsApi.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace JobsApi.Controllers
{
    [ApiController]
    [Route("api/jobs")]
    public class JobsController : ControllerBase
    {
        private readonly JobDbContext _context;
        public JobsController(JobDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var jobs = _context.Jobs.ToList();
            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        [HttpPost]
        public IActionResult Post(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = job.Id }, job);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Job input)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            job.Update(input.Title, input.Description, input.Company, input.Location, input.Salary);
            _context.Update(job);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var job = _context.Jobs.SingleOrDefault(x => x.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Remove(job);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
