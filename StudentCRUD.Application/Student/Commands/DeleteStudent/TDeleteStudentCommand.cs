using MediatR;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.DeleteStudent
{
    public record TDeleteStudentCommand(int StudentId) : IRequest<TDeleteStudentResult>;
}
