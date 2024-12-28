using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsApi.Models;

namespace QuestionsApi.Controllers
{
    [Route("api/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/admin/questions
        [HttpGet("questions")]
        public async Task<IActionResult> GetAllQuestions()
        {
            var questions = await _context.Questions.ToListAsync();
            return Ok(questions);
        }

        // POST: api/admin/questions
        [HttpPost("questions")]
        public async Task<IActionResult> AddQuestion([FromBody] Question question)
        {
            if (question == null)
            {
                return BadRequest("Invalid question data.");
            }

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAllQuestions), new { id = question.Id }, question);
        }

        // PUT: api/admin/questions/{id}
        [HttpPut("questions/{id}")]
        public async Task<IActionResult> UpdateQuestion(int id, [FromBody] Question updatedQuestion)
        {
            if (id.ToString() != updatedQuestion.Id)
            {
                return BadRequest("Question ID mismatch.");
            }

            _context.Entry(updatedQuestion).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Questions.Any(e => e.Id == id.ToString()))
                {
                    return NotFound("Question not found.");
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/admin/questions/{id}
        [HttpDelete("questions/{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound("Question not found.");
            }

            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/admin/esults
        [HttpGet("results")]
        public async Task<IActionResult> GetAllExamResults()
        {
            var results = await _context.Results.ToListAsync();
            return Ok(results);
        }
    }
}
