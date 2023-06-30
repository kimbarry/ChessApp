using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace ChessClubApi.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider fileExtensiomContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensiomContentTypeProvider
                ?? throw new System.ArgumentNullException(nameof(fileExtensiomContentTypeProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFileById(string fileId)
        {
            // look up the actual file path depending on the file id
            var pathToFile = "TODOS.txt";

            //check whether file exits
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(
                pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));

        }
    }
}
