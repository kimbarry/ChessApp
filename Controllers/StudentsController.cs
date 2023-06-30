using ChessClubApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessClubApi.Controllers
{
    [ApiController]//not strictly necessary
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<StudentDto>> GetStudents()
        {
            return Ok(StudentsDataStore.Current.Students);
        }

        [HttpGet("{id}", Name = "GetStudent")]
        public ActionResult<StudentDto> GetStudent(int id)
        {
            var studentToReturn = StudentsDataStore.Current.Students.FirstOrDefault(c => c.Id == id);

            if (studentToReturn == null)
            {
                return NotFound();
            }
            return Ok(studentToReturn);
        }

        [HttpPost]
        public ActionResult<StudentDto> CreateNewStudent(StudentForCreationDto newStudent)
        {
            //var student = StudentsDataStore.Current.Students
            var maxStudentId = StudentsDataStore.Current.Students.Max(p => p.Id);

            StudentDto finalNewStudent = new StudentDto()
            {
                Id = ++maxStudentId,
                Name = newStudent.Name,
                ParentName = newStudent.ParentName,
                Email = newStudent.Email,
                ParentCellNum = newStudent.ParentCellNum,
                StudentCellNum = newStudent.StudentCellNum,

            };
            StudentsDataStore.Current.Students.Add(finalNewStudent);


            return CreatedAtRoute("GetStudent",
                new
                {
                    id = finalNewStudent.Id
                },
                finalNewStudent);
        }
    }

    //    [HttpPut]
    //    public ActionResult PurchaseClasses(int id)
    //    {

    //    }
    //}
}
