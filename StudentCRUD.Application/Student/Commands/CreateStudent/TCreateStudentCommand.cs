using MediatR;
using StudentAPI.Application.Student.Response.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Commands.CreateStudent
{
    public record TCreateStudentCommand(
        int StudentId, 
        string FirstName, 
        string LastName, 
        string College, 
        string City, 
        int Marks
    ) : IRequest<TCreateStudentResult>;
}
