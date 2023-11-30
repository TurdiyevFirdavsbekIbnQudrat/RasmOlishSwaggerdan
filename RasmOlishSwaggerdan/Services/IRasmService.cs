using RasmOlishSwaggerdan.Model;

namespace RasmOlishSwaggerdan.Services
{
    public interface IRasmService
    {
        public ValueTask<string> GetRasm(IFormFile rasm);
    }
}
