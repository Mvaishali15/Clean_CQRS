using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Contract.Student.GetStudents
{
    public record TGetStudentsResponse(IEnumerable<StudentList> Students);

    public record StudentList(
        int StudentId,
        string FirstName,
        string LastName,
        string College,
        string City,
        int Marks
    );
}
