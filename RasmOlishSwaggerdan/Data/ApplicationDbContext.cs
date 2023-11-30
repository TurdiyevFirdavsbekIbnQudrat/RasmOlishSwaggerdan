using Microsoft.EntityFrameworkCore;
using RasmOlishSwaggerdan.Model;

namespace RasmOlishSwaggerdan.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public virtual DbSet<Rasm> rasmlar { get; set; }

    }
  
}
