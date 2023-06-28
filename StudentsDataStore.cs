using ChessClubApi.Models;

namespace ChessClubApi
{
    public class StudentsDataStore
    {
        public List<StudentDto> Students { get; set; }
        public static StudentsDataStore Current { get; } = new StudentsDataStore();

        public StudentsDataStore()
        {
            Students = new List<StudentDto>
            {
                new StudentDto()
                {
                    Id = 1,
                    Name = "Lily Detwiller",
                    ParentName = "Kim",
                    ParentCellNum = "555-555-5555",
                    Email = "s@s.com",
                    StudentCellNum = "555-555-5550",
                    PurchasedClasses = 3,
                    AttendedClasses = new List<ChessClassDto>()
                    {
                        new ChessClassDto()
                        {
                            Id = 1
                        },
                        new ChessClassDto()
                        {
                            Id = 2
                        },
                        new ChessClassDto()
                        {
                           Id = 3
                        },

                    },


                },
                new StudentDto()
                {
                    Id = 2,
                    Name = "Sean Detwiller",
                    ParentName = "Kim",
                    ParentCellNum = "555-555-5555",
                    Email = "s",
                    StudentCellNum = "555-555-5551",
                    PurchasedClasses = 10,

                    AttendedClasses = new List<ChessClassDto>()
                    {
                        new ChessClassDto()
                        {
                           Id = 1
                        },
                        new ChessClassDto()
                        {
                            Id = 2
                        },
                        new ChessClassDto()
                        {
                            Id = 3
                        },

                    }
                },
                new StudentDto()
                {
                    Id = 3,
                    Name = "Noelle Detwiller",
                    ParentName = "Kim",
                    ParentCellNum = "555-555-5555",
                    Email = "s",
                    StudentCellNum = "555-555-5553",
                    PurchasedClasses = 10,
                    AttendedClasses = new List<ChessClassDto>()
                    {
                        new ChessClassDto()
                        {
                            Id = 1
                        },
                        new ChessClassDto()
                        {
                            Id = 3
                        }
                        


                    }
                }
            };
        }
    }
}
