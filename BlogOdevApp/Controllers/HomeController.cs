using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogOdevApp.Models;

namespace BlogOdevApp.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        var posts = getAllPosts();
    
        return View(posts);
        
    }

    public IActionResult Iletisim()
    {
        return View();
    }

    public IActionResult Hakkimda()
    {
        return View();
    }
    public IActionResult Detay(string id)
    {
        using StreamReader reader = new StreamReader($"AppData/posts/icerik-detay.txt");
        var postContent = reader.ReadToEnd();

        var postDetail = new Post();
        postDetail.Title = "Post Detay";
        postDetail.Content = postContent;

        ViewData["title"] = "Gönderi Detay";

        return View(postDetail);
    }

    public IActionResult Detays()
    {
        using StreamReader reader = new StreamReader($"AppData/posts/icerik-detay2.txt");
        var postContent = reader.ReadToEnd();

        var postDetail = new Post();
        postDetail.Title = "Post Detay 2";
        postDetail.Content = postContent;

        ViewData["title"] = "Gönderi Detay 2";

        return View(postDetail);
        
    }
    public List<Post> getAllPosts()
    {
        var posts = new List<Post>();
        using StreamReader reader = new StreamReader("AppData/posts/index.txt");
        var postsTxt = reader.ReadToEnd();
        var postsLines = postsTxt.Split('\n');
        foreach (var postLine in postsLines)
        {
            var postParts = postLine.Split('|');
            posts.Add(
                new Post()
                {
                    Title = postParts[0],
                    Summary = postParts[1],
                    Slug = postParts[3]
                }
            );
        }
        return posts;
    }

   

    
}