namespace ChessClubApi.Models
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ParentName { get; set; }
        public string ParentCellNum { get; set; }
        public string Email { get; set; }
        public string? StudentCellNum { get; set; }
        public int PurchasedClasses { get; set; } = 0;
        public int ClassBank => PurchasedClasses - NumberOfClassesAttended;
        public int NumberOfClassesAttended => AttendedClasses.Count; //expression bodied property

        
        public ICollection<ChessClassDto> AttendedClasses { get; set; } = new List<ChessClassDto>();
    }
}
