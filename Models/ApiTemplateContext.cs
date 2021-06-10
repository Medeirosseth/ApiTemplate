using Microsoft.EntityFrameworkCore;

namespace ApiTemplate.Models
{
  public class ApiTemplateContext : DbContext
  {
    public ApiTemplateContext(DbContextOptions<ApiTemplateContext>options)
    : base(options)
    {
    }

    public DbSet<ModelName> ModelName { get; set; }
  }
}