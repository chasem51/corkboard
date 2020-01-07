using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corkboard.Models;
using corkboard.Data;
using corkboard.Controllers;

namespace corkboard.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CoursePropsController : ControllerBase
    {
        private readonly CoursePropsContext _context;
        private readonly IDataRepository<CourseProp> _repo;

        public CoursePropsController(CoursePropsContext context, IDataRepository<CourseProp> repo)
        { 
            _context = context;
            _repo = repo;
        }

        // GET: api/CourseProp
        [HttpGet]
        public IEnumerable<CourseProp> GetCourseProps()
        {
            return _context.CourseProp.OrderByDescending(p => p.PostId);
        }

        // GET: api/BlogPosts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseProp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseProp = await _context.CourseProp.FindAsync(id);

            if (courseProp == null)
            {
                return NotFound();
            }

            return Ok(courseProp);
        }

        // PUT: api/BlogPosts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseProp([FromRoute] int id, [FromBody] CourseProp courseProp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != courseProp.PostId)
            {
                return BadRequest();
            }

            _context.Entry(courseProp).State = EntityState.Modified;

            try
            {
                _repo.Update(courseProp);
                var save = await _repo.SaveAsync(courseProp);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoursePropExists(id))
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

        // POST: api/CourseProps
        [HttpPost]
        public async Task<IActionResult> PostCourseProp([FromBody] CourseProp courseProp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repo.Add(courseProp);
            var save = await _repo.SaveAsync(courseProp);

            return CreatedAtAction("GetCourseProp", new { id = courseProp.PostId }, courseProp);
        }

        // DELETE: api/BlogPosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseProp([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var courseProp = await _context.CourseProp.FindAsync(id);
            if (courseProp == null)
            {
                return NotFound();
            }

            _repo.Delete(courseProp);
            var save = await _repo.SaveAsync(courseProp);

            return Ok(courseProp);
        }

        private bool CoursePropExists(int id)
        {
            return _context.CourseProp.Any(e => e.PostId == id);
        }
    }
}
