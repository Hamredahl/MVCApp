using Microsoft.AspNetCore.Mvc;
using WorkoutApp.Web.Models;
using WorkoutApp.Web.Services;

namespace WorkoutApp.Web.Controllers;

public class ExercisesController : Controller
{
    ExerciseService exerciseService = new ExerciseService();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = exerciseService.GetAll();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Exercise exercise)
    {
        if (!ModelState.IsValid) return View();
        exerciseService.Add(exercise);
        return RedirectToAction("Index");
    }

    [HttpGet("details/{Id}")]
    public IActionResult Details(int Id)
    {
        var model = exerciseService.GetById(Id);
        return View(model);
    }
}
