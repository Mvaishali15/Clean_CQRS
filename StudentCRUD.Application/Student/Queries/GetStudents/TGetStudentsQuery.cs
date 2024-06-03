using MediatR;
using StudentAPI.Application.Student.Response.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Queries.GetStudents
{
    public record TGetStudentsQuery() : IRequest<TGetStudentsResult>;
}
