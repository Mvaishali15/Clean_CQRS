using StudentAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Application.Student.Response.Queries
{
    public record TGetStudentsResult(IEnumerable<TStudent> Stu);
}
