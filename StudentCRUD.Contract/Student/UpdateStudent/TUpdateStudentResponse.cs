using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI.Contract.Student.UpdateStudent
{
    public record TUpdateStudentResponse(UpdateStudent Stu);

    public record UpdateStudent(
        int StudentId,
        string FirstName,
        string LastName,
        string College,
        string City,
        int Marks
    );
}
