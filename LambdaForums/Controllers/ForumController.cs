using System.Linq;
using LambdaForums.Data.Interfaces;
using LambdaForums.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LambdaForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly Ipost _postService;

        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }  
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel {            
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
            });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = _postService.GetFilteredPosts(id);

            var postListings = 

        }
    }
}
