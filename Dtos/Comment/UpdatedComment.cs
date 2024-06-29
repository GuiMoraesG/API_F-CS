using System.ComponentModel.DataAnnotations;

namespace API_F_CS.Dtos.Comment
{
    public class UpdatedComment
    {
        [Required]
        public string Text { get; set; } = string.Empty;
    }
}
