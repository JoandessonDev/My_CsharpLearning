using Microsoft.EntityFrameworkCore;

namespace ProductServer.Context
{
    public class DtContext(DbContextOptions<DtContext> options) : DbContext(options)
    {
    }
}
