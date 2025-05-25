using Microsoft.AspNetCore.Mvc;
using WorkoutApp.Web.Models;
using WorkoutApp.Web.Services;
using WorkoutApp.Web.Views.Exercises;

namespace WorkoutApp.Web.Controllers;

public class ExercisesController(ExerciseService exerciseService) : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        var model = exerciseService.GetAll();
        var viewModel = new IndexVM
        {
            Exercises = model
                .Select(e => new IndexVM.ExerciseVM
                {
                    Name = e.Name,
                    Id = e.Id,
                })
                .ToArray()
        };
        return View(viewModel);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(CreateVM viewModel)
    {
        if (!ModelState.IsValid) return View();

        Exercise exercise = new()
        {
            Name = viewModel.Name,
            Sets = viewModel.Sets,
            Reps = viewModel.Reps,
        };
        exerciseService.Add(exercise);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet("details/{Id}")]
    public IActionResult Details(int Id)
    {
        var model = exerciseService.GetById(Id);

        DetailsVM viewModel = new()
        {
            Name = model.Name,
            Sets = model.Sets,
            Reps = model.Reps,
        };

        return View(viewModel);
    }
}
