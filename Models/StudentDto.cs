using System.ComponentModel.DataAnnotations;

namespace ChessClubApi.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string? ParentName { get; set; }
        [Required(ErrorMessage = "You should provide a parent cell number value.")]
        [Phone]
        public string ParentCellNum { get; set; }
        [Required(ErrorMessage = "You should provide an email value.")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string? StudentCellNum { get; set; }
        public int PurchasedClasses { get; set; } = 0;
        public int ClassBank => PurchasedClasses - NumberOfClassesAttended;
        public int NumberOfClassesAttended => AttendedClasses.Count; //expression bodied property

        
        public ICollection<ChessClassDto> AttendedClasses { get; set; } = new List<ChessClassDto>();
    }
}
