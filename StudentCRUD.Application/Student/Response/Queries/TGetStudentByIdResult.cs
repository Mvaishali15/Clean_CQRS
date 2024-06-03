using StudentAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Response.Queries
{
    //public record TGetStudentByIdResult(IEnumerable<GetSingleStu> Student);
    //public record GetSingleStu (
    //    int StudentId,
    //    string FirstName,
    //    string LastName,
    //    string College,
    //    string City,
    //    int Marks
    //);

    public record TGetStudentByIdResult(TStudent Student);
}
