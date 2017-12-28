using Blogifier.Core.Data.Models;
using System.Threading.Tasks;

namespace Blogifier.Core.Services.Data
{
    public interface IDataService
    {
        Task<BlogPostsModel> GetPostsAsync(int page, bool pub = false);
        Task<BlogAuthorModel> GetPostsByAuthorAsync(string auth, int page, bool pub = false);
        BlogCategoryModel GetPostsByCategory(string auth, string cat, int page, bool pub = false);
        BlogCategoryModel GetAllPostsByCategory(string cat, int page, bool pub = false);
        BlogPostDetailModel GetPostBySlug(string slug, bool pub = false);
        BlogPostsModel SearchPosts(string term, int page, bool pub = false);
    }
}