namespace WorkoutApp.Web.Views.Exercises
{
    public class IndexVM
    {
        public required ExerciseVM[] Exercises { get; set; }
        public class ExerciseVM
        {
            public required string Name { get; set; }
            public required int Id { get; set; }
        }
    }
}
