
using Microsoft.AspNetCore.Mvc;
using dijital_asistan.Services; // Bu satırı ekleyin
namespace dijital_asistan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly VeritabaniTestService _veritabaniTestService;

        public TestController(VeritabaniTestService veritabaniTestService)
        {
            _veritabaniTestService = veritabaniTestService;
        }

        [HttpGet("test-baglanti")]
        public async Task<IActionResult> TestBaglanti()
        {
            var result = await _veritabaniTestService.TestBaglantiAsync();
            return Ok(result);
        }
    }

}