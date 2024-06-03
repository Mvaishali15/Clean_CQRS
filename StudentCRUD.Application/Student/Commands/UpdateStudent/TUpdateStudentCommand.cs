using MediatR;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.UpdateStudent
{
    public record TUpdateStudentCommand(
        int StudentId,
        string FirstName,
        string LastName,
        string College,
        string City,
        int Marks
    ) : IRequest<TUpdateStudentResult>;
}
