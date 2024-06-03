using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Application.Student.Commands.CreateStudent;
using StudentAPI.Application.Student.Commands.DeleteStudent;
using StudentAPI.Application.Student.Commands.UpdateStudent;
using StudentAPI.Application.Student.Queries.GetStudentById;
using StudentAPI.Application.Student.Queries.GetStudents;
using StudentAPI.Contract.Student.CreateStudent;
using StudentAPI.Contract.Student.DeleteStudent;
using StudentAPI.Contract.Student.GetStudentById;
using StudentAPI.Contract.Student.GetStudents;
using StudentAPI.Contract.Student.UpdateStudent;

namespace StudentAPI.Controllers
{
    [Route("/Students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public StudentController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            var request = new TGetStudentsQuery();
            var authResult = await _mediator.Send(request);
            var response = _mapper.Map<TGetStudentsResponse>(authResult);

            return Ok(response);
        }

        [HttpGet("GetById/{StudentId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int StudentId)
        {
            var request = new TGetStudentByIdRequest(StudentId);
            var query = _mapper.Map<TGetStudentByIdQuery>(request);
            var authResult = await _mediator.Send(query);
            var response = _mapper.Map<TGetStudentByIdResponse>(authResult);

            return Ok(response);
        }

        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<IActionResult> CreateEmployee(TCreateStudentRequest request)
        {
            var command = _mapper.Map<TCreateStudentCommand>(request);
            var authResult = await _mediator.Send(command);
            var response = _mapper.Map<TCreateStudentResponse>(authResult);

            return Ok(response);
        }

        [HttpDelete("Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public async Task<IActionResult> DeleteEmployee(int StudentId)
        {
            var request = new TDeleteStudentRequest(StudentId);
            var query = _mapper.Map<TDeleteStudentCommand>(request);
            var authResult = await _mediator.Send(query);
            var response = _mapper.Map<TDeleteStudentResponse>(authResult);

            return Ok(response);
        }

        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateEmployee(TUpdateStudentRequest request)
        {
            var command = _mapper.Map<TUpdateStudentCommand>(request);
            var authResult = await _mediator.Send(command);
            var response = _mapper.Map<TUpdateStudentResponse>(authResult);
            return Ok(response);
        }
    }
}
