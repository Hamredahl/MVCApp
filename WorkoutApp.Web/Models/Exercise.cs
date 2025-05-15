using System.ComponentModel.DataAnnotations;

namespace WorkoutApp.Web.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; } = null!;
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
