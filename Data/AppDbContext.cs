using Microsoft.EntityFrameworkCore;

namespace citros_api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}
