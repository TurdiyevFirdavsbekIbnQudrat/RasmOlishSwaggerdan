using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RasmOlishSwaggerdan.Data;
using RasmOlishSwaggerdan.Model;
using RasmOlishSwaggerdan.Services;

namespace RasmOlishSwaggerdan.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RasmController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IRasmService rasmService;
        public RasmController(ApplicationDbContext applicationDbContext, IRasmService rasmService)
        {
            _applicationDbContext = applicationDbContext;
            this.rasmService = rasmService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> getData([FromForm] Rasm rasm)
        {
            Rasm rassm = new Rasm()
            {
                ImageUrl = await rasmService.GetRasm(rasm.Image),
                Name = rasm.Name,
            };
            await _applicationDbContext.AddAsync(rassm);
            await _applicationDbContext.SaveChangesAsync();
            return Ok(rassm);
        }
    }
}
