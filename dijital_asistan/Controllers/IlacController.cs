using dijital_asistan.Entities;
using dijital_asistan.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dijital_asistan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IlacController : ControllerBase
    {
        private readonly IlacRepository _repository;

        public IlacController(IlacRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ilac>>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ilac>> GetById(int id)
        {
            var ilac = await _repository.GetByIdAsync(id);
            if (ilac == null) return NotFound();
            return ilac;
        }

        [HttpPost]
        public async Task<ActionResult> Add(Ilac ilac)
        {
            await _repository.AddAsync(ilac);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Ilac ilac)
        {
            if (id != ilac.IlacId) return BadRequest();
            await _repository.UpdateAsync(ilac);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }
    }
}
