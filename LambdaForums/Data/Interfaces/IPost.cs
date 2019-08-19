using LambdaForums.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LambdaForums.Data.Interfaces
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(Forum forum, string searchQuery);
        IEnumerable<Post> GetPostsByForumId(int id);
        IEnumerable<Post> GetLatestPosts(int n);


        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
    }
}
