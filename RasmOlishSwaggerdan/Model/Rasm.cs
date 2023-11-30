using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RasmOlishSwaggerdan.Model
{
    public class Rasm
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
