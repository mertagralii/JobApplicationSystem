using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JobApplicationSystem.Models;
using JobApplicationSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationSystem.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.WorkCategory.ToList());
    }
    public IActionResult WorkDetail(int Id) 
    {
        var workCategoryDetail = _context.WorkCategory.Find(Id);
        return View();
    }

}
