using System.Linq;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

public class HomeController : Controller
{
    private readonly IUnitOfWork<Developer> _developer;
    private readonly IUnitOfWork<ProjectItem> _projectItem;
    public HomeController(IUnitOfWork<Developer> developer,
    IUnitOfWork<ProjectItem> projectItem)
    {
        _projectItem = projectItem;
        _developer = developer;
    }
    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel
        {
            Developer = _developer.Entity.GetAll().First(),
            ProjectItem = _projectItem.Entity.GetAll()
        };
        return View(homeViewModel);
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Error()
    {
        return View();
    }
}