using ChessClubApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChessClubApi.Controllers
{
    [ApiController]//not strictly necessary
    [Route("api/students")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<StudentDto>> GetStudents()
        {
            return Ok(StudentsDataStore.Current.Students);
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDto> GetStudent(int id)
        {
            var studentToReturn = StudentsDataStore.Current.Students.FirstOrDefault(c => c.Id == id);

            if (studentToReturn == null)
            {
                return NotFound();
            }
            return Ok(studentToReturn);
        }
    }

    //    [HttpPut]
    //    public ActionResult PurchaseClasses(int id)
    //    {

    //    }
    //}
}
