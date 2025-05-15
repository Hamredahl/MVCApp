using WorkoutApp.Web.Models;

namespace WorkoutApp.Web.Services;

public class ExerciseService
{
    private static List<Exercise> exercises = new List<Exercise>();

    public void Add(Exercise exercise)
    {
        exercise.Id = exercises.Count == 0 ? 1 : exercises.Max(e => e.Id);
        exercises.Add(exercise);
    }

    public Exercise[] GetAll() => exercises
        .OrderBy(e => e.Name)
        .ToArray();

    public Exercise? GetById(int Id) => exercises
        .SingleOrDefault(e => e.Id == Id);
}