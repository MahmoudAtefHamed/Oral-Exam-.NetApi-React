using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionsApi.Models;

namespace QuestionsApi.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class ResultsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ResultsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST: api/results
    [HttpPost]
    public async Task<IActionResult> PostResult([FromBody] Result result)
    {
        if (result == null)
        {
            return BadRequest();
        }

        _context.Results.Add(result);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetResult", new { id = result.Id }, result);
    }

    // GET: api/results
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Result>>> GetResults()
    {
        return await _context.Results.ToListAsync();
    }
}

}
