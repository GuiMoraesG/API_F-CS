using System.ComponentModel.DataAnnotations;

namespace API_F_CS.Dtos.Post
{
    public class CreatePost
    {
        [Required(ErrorMessage = "Field is required")]
        [MinLength(3, ErrorMessage = "The field must be over 3 letters")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Field is required")]
        [MinLength(3, ErrorMessage = "The field must be over 3 letters")]
        public string Description { get; set; } = string.Empty;
    }
}
