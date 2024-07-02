using Microsoft.AspNetCore.Mvc;
using CreateServer.Models;
using System.Text.Json;


namespace CreateServer.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class PostsController : ControllerBase
{
    private const string FilePath = "posts.json";

    private readonly JsonSerializerOptions _options = new() { WriteIndented = true, PropertyNameCaseInsensitive = true };

    [HttpGet]
    public IActionResult Get()
    {
        if (!System.IO.File.Exists(FilePath))
            return NotFound();

        string posts = System.IO.File.ReadAllText(FilePath);
        return Ok(posts);
    }

    [HttpPost]
    public IActionResult CreatePost([FromBody] Post post)
    {
        if (!System.IO.File.Exists(FilePath))
            return NotFound();

        string postsJson = System.IO.File.ReadAllText(FilePath);
        List<Post> posts = JsonSerializer.Deserialize<List<Post>>(postsJson, _options)!;
        posts.Add(post);
        postsJson = JsonSerializer.Serialize(posts, _options);
        System.IO.File.WriteAllText(FilePath, postsJson);
        return Ok(post);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        string postsJson = System.IO.File.ReadAllText(FilePath);
        List<Post> posts = JsonSerializer.Deserialize<List<Post>>(postsJson, _options)!;
        Post? post = posts.SingleOrDefault(p => p.id == id);

        if (post is null)
        {
            return NotFound();
        }

        return Ok(post);
    }
}
