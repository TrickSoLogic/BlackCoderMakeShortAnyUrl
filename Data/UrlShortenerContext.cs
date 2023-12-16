using Microsoft.EntityFrameworkCore;
using BlackCoderMakeShortAnyUrl.Models;

namespace BlackCoderMakeShortAnyUrl.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ShortUrl> ShortUrls { get; set; }
    }
}
