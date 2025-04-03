using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.API_PresentationLayer_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IMediator mediator;

        public StudentController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudents()
        {
            var response = await mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
    }
}
