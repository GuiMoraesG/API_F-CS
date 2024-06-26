using System.ComponentModel.DataAnnotations;

namespace API_F_CS.Dtos.Comment
{
    public class CreatedComment
    {
        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
