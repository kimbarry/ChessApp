using System.ComponentModel.DataAnnotations;

namespace ChessClubApi.Models
{
    public class StudentForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string? ParentName { get; set; }
        [Required(ErrorMessage = "You should provide a cell phone number.")]
        [Phone]
        public string ParentCellNum { get; set; }
        [Required(ErrorMessage = "You shoiuld provide an email.")]
        [EmailAddress]
        public string Email { get; set; } = "";
        [Phone]
        public string? StudentCellNum { get; set; }
    }
}
