using System.Threading.Tasks;
using Blogifier.Core.Data.Models;
using System.Net.Http;

namespace Blogifier.Core.Services.Syndication.Rss
{
    public interface IRssService
    {
        Task<HttpResponseMessage> Import(RssImportModel model);
        Task<string> DisplayAsync(string absoluteUri, string author);
    }
}
