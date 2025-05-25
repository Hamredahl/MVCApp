using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Web.Views.Exercises
{
    public class CreateVM
    {
        [Required(ErrorMessage = "Exercise must have a name")]
        [MinLength(3, ErrorMessage ="Exercise name must be at least 3 characters")]
        [Display(Name = "Exercise", Prompt = "Name of exercise")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Enter amount of sets")]
        [Range(1, int.MaxValue, ErrorMessage = "Sets cannot be less than 1")]
        [Display(Name = "Sets", Prompt = "Amount of sets")]
        public required int Sets { get; set; }

        [Required(ErrorMessage = "Enter amount of reps")]
        [Range(1, int.MaxValue, ErrorMessage = "Reps cannot be less than 1")]
        [Display(Name = "Reps", Prompt = "Amount of reps")]
        public required int Reps { get; set; }
    }
}
