using Library.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    public class AuthorsController : Controller
    {
        private ILibraryRepository _libraryRepository;
        public AuthorsController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();
            return new JsonResult(authorsFromRepo);
        }
    }
}
