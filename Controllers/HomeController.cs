using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMvcDockerTest.Interfaces;
using WebMvcDockerTest.Models;

namespace WebMvcDockerTest.Controllers;

public class HomeController : Controller
{
    private readonly IRepository _repository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly string _message;

    public HomeController(IRepository repository, IHttpContextAccessor httpContextAccessor)
    {
        _repository = repository;
        _httpContextAccessor = httpContextAccessor;
        var hostname = _httpContextAccessor.HttpContext?.Request.Host.Value ?? "ASP NET Core MVC - Docker";
        _message = $"Docker - ({hostname})";
    }

    public IActionResult Index()
    {
        ViewBag.Message = _message;
        return View(_repository.Products);
    }
}
