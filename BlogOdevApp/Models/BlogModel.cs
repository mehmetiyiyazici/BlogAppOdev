namespace BlogOdevApp.Models;

public class Post
{
    public string Title { get; set; }
    
    public string Summary { get; set; }

    public string Content { get; set; }
    
    public string ImgUrl { get; set; }
    public string Slug { get; set; } // kullanici dostu adres icin kullandigimiz terim

    public string Content2 { get; set; }
}
