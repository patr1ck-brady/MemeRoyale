using MemeRoyale.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MemeRoyale.Controllers
{
    [Route("api/[controller]")]
    public class GiphyController : ControllerBase
    {
        private readonly IGiphyService _giphyService;

        public GiphyController(IGiphyService giphyService)
        {
            _giphyService = giphyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomGif(int limit = 1)
        {
            var result = await _giphyService.GetRandomGif(limit);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
