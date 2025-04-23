using GuitarJournal.Application.DTOs;
using GuitarJournal.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GuitarJournal.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PracticeSessionsController : ControllerBase
    {
        private readonly IPracticeSessionService _service;

        public PracticeSessionsController(IPracticeSessionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePracticeSessionDto dto)
        {
            var created = await _service.CreateAsync(dto);

            return CreatedAtAction("CREATE", new { id = created.Id }, created);
        }
    }
}