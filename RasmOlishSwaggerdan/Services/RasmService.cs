using RasmOlishSwaggerdan.Data;
using RasmOlishSwaggerdan.Model;

namespace RasmOlishSwaggerdan.Services
{
    public class RasmService : IRasmService
    {
        private readonly ApplicationDbContext applicationDbContext;

        private readonly IWebHostEnvironment webHostEnvironment;
        public RasmService(ApplicationDbContext applicationDbContext, IWebHostEnvironment webHostBuilder)
        {
            this.applicationDbContext = applicationDbContext;
            webHostEnvironment = webHostBuilder;
        }

        public async ValueTask<string> GetRasm(IFormFile rasm)
        {
            string extension = Path.GetExtension(rasm.FileName);
            string path =  webHostEnvironment.WebRootPath + "/Images/" + Guid.NewGuid() + extension;
            using (FileStream file = new FileStream(path, FileMode.Create))
            {
                await rasm.CopyToAsync(file);   
            }
            return path;
        }
    }
}
