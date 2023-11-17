using Microsoft.AspNetCore.Mvc;
using WebApplication1.HomeViewModel;
using WebApplication1.Models;

namespace WebApplication1.HomeController
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {


            List<Feature> features = new List<Feature>();
            Feature feature = new Feature() { Id = 1, Description = "feat1", Name = "nam1" };
            Feature feature1 = new Feature() { Id = 2, Description = "feat2", Name = "name2" };
            Feature feature2 = new Feature() { Id = 3, Description = "feat3", Name = "name3" };
            Feature feature3 = new Feature() { Id = 4, Description = "feat4", Name = "name4" };
            features.Add(feature);
            features.Add(feature1);
            features.Add(feature2);
            features.Add(feature3);



            List<Blog> blogs = new List<Blog>();
            Blog blog = new Blog() { Id = 1, AuthorName = "remzi", Title = "title1", Description = "desc1" };
            Blog blog1 = new Blog() { Id = 2, AuthorName = "ramzes", Title = "title2", Description = "desc2" };
            Blog blog2 = new Blog() { Id = 3, AuthorName = "ramsey", Title = "title3", Description = "desc3" };
            Blog blog3 = new Blog() { Id = 4, AuthorName = "ramiz", Title = "title4", Description = "desc4" };
            blogs.Add(blog);
            blogs.Add(blog1);
            blogs.Add(blog2);
            blogs.Add(blog3);

            ViewModel viewModel = new ViewModel();
            viewModel.Blogs = blogs;
            viewModel.Features = features;

            return View(viewModel);
           
        }
    }
}
