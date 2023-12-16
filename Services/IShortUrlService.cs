using BlackCoderMakeShortAnyUrl.Models;

namespace BlackCoderMakeShortAnyUrl.Services
{
    public interface IShortUrlService
    {
        ShortUrl GetById(int id);

        ShortUrl GetByPath(string path);

        ShortUrl GetByOriginalUrl(string originalUrl);

        int Save(ShortUrl shortUrl);
    }
}
