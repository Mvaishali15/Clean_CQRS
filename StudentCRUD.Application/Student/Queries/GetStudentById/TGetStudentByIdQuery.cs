using MediatR;
using StudentAPI.Application.Student.Response.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Queries.GetStudentById
{
    public record TGetStudentByIdQuery(int StudentId) : IRequest<TGetStudentByIdResult>;
}
