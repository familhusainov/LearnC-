using System.ComponentModel.DataAnnotations;

namespace LearnApi.Model.PostModels
{
    public class GradePostModel
    {
        public int Id { get; set; }

        public string? GradeName { get; set; }
        [Required(ErrorMessage ="Sectionu doldurun mecburidir")]

        public string? Section { get; set; }
    }
}
