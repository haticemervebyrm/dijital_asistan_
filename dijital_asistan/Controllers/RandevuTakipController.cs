using dijital_asistan.Entities;
using dijital_asistan.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dijital_asistan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandevuTakipController : ControllerBase
    {
        private readonly RandevuTakipRepository _repository;

        public RandevuTakipController(RandevuTakipRepository repository)
        {
            _repository = repository;
        }

        // Get all appointments (Only RandevuTakip data)
        [HttpGet]
        public async Task<ActionResult<List<RandevuTakip>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        // Get appointment by id (Only RandevuTakip data)
        [HttpGet("{id}")]
        public async Task<ActionResult<RandevuTakip>> GetById(int id)
        {
            var randevu = await _repository.GetByIdAsync(id);
            if (randevu == null) return NotFound();
            return randevu;
        }

        // Add a new appointment
        [HttpPost]
        public async Task<ActionResult> Add(RandevuTakip randevu)
        {
            await _repository.AddAsync(randevu);
            return Ok();
        }

        // Update an existing appointment
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, RandevuTakip randevu)
        {
            if (id != randevu.RandevuId) return BadRequest();
            await _repository.UpdateAsync(randevu);
            return Ok();
        }

        // Delete an appointment
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
